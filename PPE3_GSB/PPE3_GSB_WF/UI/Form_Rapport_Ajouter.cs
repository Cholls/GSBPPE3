using PPE3_GSB_WF.Accès_aux_données;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_GSB_WF.UI
{

    public partial class Form_Rapport_Ajouter : Form
    {
        private GSB_PPE3Entities1 monModele;
        string matriculeVis;
        int matriculePra;
        int matriculePraBis;
        string motif;
        string regionVisiteur;
        string dateVisite;
        string texteBilan;
        string medOffert;
        string qtOffert;
        string depotLegal;
        int numRapport;
        public Form_Rapport_Ajouter()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        private void Form_Rapport_Ajouter_Load(object sender, EventArgs e)
        {
            //Affiche la liste des médicaments
            var reqEchan = from m in monModele.medicaments
                      select m.MED_NOMCOMMERCIAL;

            foreach (var resultat in reqEchan)
            {
                cb_select.Items.Add(resultat);
            }

            // Il faut charger la liste des motifs pour le comboBox des motifs
            var req = from p in monModele.motifs
                      select p.MOT_LIBELLE;

            foreach(var res in req)
            {
                cb_motif.Items.Add(res);
            }

            // Recherche de la région du visiteur connecté
            var req2 = from p in monModele.visiteurs
                      where p.VIS_NOM == tb_nomVis.Text
                      select p.REG_CODE;

            foreach (var resultat in req2)
            {
                regionVisiteur = resultat;
            }

            // Faire en sorte de n'afficher que les praticiens uniquement dans 
            // la même région que le visiteur 
            var req1 = from p in monModele.praticiens
                       where p.REG_CODE == regionVisiteur
                       select p;

            cb_praticienBis.Items.Add("Aucun");
            // Ajout des médecins dans le comboBox correspondant au cp du visiteur
            foreach (var resultat in req1)
            {
                cb_praticien.Items.Add(resultat.PRA_NOM);
                cb_praticienBis.Items.Add(resultat.PRA_NOM);
            }
        }

        // Permet de valider l'ajout d'un nouveau rapport
        private void bt_valid_Click(object sender, EventArgs e)
        {
            
            // Tout d'abord, générer un numéro de dossier random
            // sans que ce numéro soit déjà dans la base
            Random aleatoire = new Random();
            numRapport = aleatoire.Next(7, 100); //Génère un entier aléatoire positif

            // Permet de générer et d'attribuer un numéro de rapport, sans que celui-ci ne soit déjà dans la base
            do
            {
                numRapport = aleatoire.Next(1, 1000);
                
            } while (monModele.rapport_visite.Any(a => a.RAP_NUM == numRapport));
            MessageBox.Show("Bravo, numéro de rapport généré : " + numRapport + ".");
            // Ensuite il faut récupérer le matricule du visiteur
            var req = from p in monModele.visiteurs
                      where p.VIS_NOM == tb_nomVis.Text
                      select p.VIS_MATRICULE;
                       
            foreach(var res in req)
            {
                matriculeVis = res;
            }

            // Maintenant, on veut récupérer la date d'aujourd'hui pour la mettre en DATE DE SAISIE
            string dateToday = DateTime.Now.ToString("yyyy-MM-dd");


            // Maintenant vérification des saisies
            //Vérifie que rien ne soit vide 
            if (cb_praticien.Text == "" && tb_bilan.Text == "" && cb_motif.Text == "")
            {
                MessageBox.Show("Un ou plusieurs champs est/sont vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // ETAPE UN RECUP MOTIF
                    // Récupération du contenu du combobox du motif
                    string recupMotif = cb_motif.SelectedItem.ToString();
                    // Dans le combobox du type, on récupère le code du motif
                    // pour pouvoir le mettre dans la base de données

                    var req1 = from p in monModele.motifs
                               where p.MOT_LIBELLE == recupMotif
                               select p.MOT_CODE;

                    // Récupération du code du motif
                    foreach (var res in req1) { motif = res; }

                    
                    // ETAPE UN RECUP MATRICULE PRATICIEN PREMIER
                    // Récupération du contenu du comboBox du premier praticien (obligatoire)
                    string recupPra = cb_praticien.SelectedItem.ToString();

                    var reqRecupPra = from p in monModele.praticiens
                                      where p.PRA_NOM == recupPra
                                      select p.PRA_NUM;
                    // Récupération du matricule du premier praticien
                    foreach (var recup in reqRecupPra) { matriculePra = recup; }


                    // ETAPE UN RECUP MATRICULE PRATICIEN BIS SI SELECTION PAS AUCUN
                    if (cb_praticienBis.Text == "Aucun")
                    {
                        // A mettre null dans la base de données
                        matriculePraBis = 0;
                        var unRapport = new rapport_visite()
                        {
                            VIS_MATRICULE = matriculeVis,
                            RAP_NUM = numRapport,
                            PRA_NUM = matriculePra,
                            PRA_NUM_REMPLACANT = null,
                            RAP_DATE_SAISIE = Convert.ToDateTime(dateToday),
                            RAP_DATE_VISITE = Convert.ToDateTime(dateVisite),
                            RAP_BILAN = texteBilan,
                            RAP_MOTIF_AUTRE = null,
                            MOT_CODE = motif,
                            RAP_DOCUMENTATION = 0,
                            RAP_SAISIEDEFINITIVE = 0
                        };

                        // Ajout du rapport dans la liste gérees par le programme
                        monModele.rapport_visite.Add(unRapport);
                        // Sauvegarde de l'ajout dans la BDD
                        monModele.SaveChanges();

                        MessageBox.Show("Nouveau rapport " + numRapport + " bien ajouté. Merci " + tb_nomVis.Text + ".", "Ajout confirmé", MessageBoxButtons.OK);
                        panelMed.Visible = true;
                        bt_valid.Enabled = false;
                    }
                    else
                    {
                        // Récupération du contenu du comboBox du deuxième praticien 
                        string recupPraBis = cb_praticienBis.SelectedItem.ToString();

                        var reqRecupPraBis = from p in monModele.praticiens
                                             where p.PRA_NOM == recupPraBis
                                             select p.PRA_NUM;
                        // Récupération du matricule du deuxième praticien
                        foreach (var recup in reqRecupPraBis) { matriculePraBis = recup; }

                        var unRapport = new rapport_visite()
                        {
                            VIS_MATRICULE = matriculeVis,
                            RAP_NUM = numRapport,
                            PRA_NUM = matriculePra,
                            PRA_NUM_REMPLACANT = matriculePraBis,
                            RAP_DATE_SAISIE = Convert.ToDateTime(dateToday),
                            RAP_DATE_VISITE = Convert.ToDateTime(dateVisite),
                            RAP_BILAN = texteBilan,
                            RAP_MOTIF_AUTRE = null,
                            MOT_CODE = motif,
                            RAP_DOCUMENTATION = 0,
                            RAP_SAISIEDEFINITIVE = 0
                        };

                        // Ajout du rapport dans la liste gérees par le programme
                        monModele.rapport_visite.Add(unRapport);
                        // Sauvegarde de l'ajout dans la BDD
                        monModele.SaveChanges();

                        MessageBox.Show("Nouveau rapport " + numRapport + " bien ajouté. Merci " + tb_nomVis.Text + ".", "Ajout confirmé", MessageBoxButtons.OK);
                        panelMed.Visible = true;
                        bt_valid.Enabled = false;
                    }

                    // ETAPE RECUP DATE DE VISITE
                    dateVisite = dateVisitePick.Value.ToString("yyyy-MM-dd");
                    // ETAPE RECUP SAISIE BILAN
                    texteBilan = tb_bilan.Text;

                    


                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Erreur, reessayez.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Problème interne base de données....", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Permettant d'ajouter un échantillon
        private void button1_Click_1(object sender, EventArgs e)
        {
            try{
                medOffert = cb_select.Text;
                qtOffert = Convert.ToString(tb_qt.Text);
                var trouverDepotLegal = from p in monModele.medicaments
                                        where p.MED_NOMCOMMERCIAL == medOffert
                                        select p.MED_DEPOTLEGAL;
                foreach (var res in trouverDepotLegal)
                {
                    depotLegal = res;
                }

                // Maintenant il faut les afficher dans le datagridview
                dgvMedicament.Rows.Add(medOffert, qtOffert);
                
                var unEchantillon = new offrir()
                {
                    VIS_MATRICULE = matriculeVis,
                    RAP_NUM = numRapport,
                    MED_DEPOTLEGAL = depotLegal,
                    OFF_QTE = Convert.ToInt32(qtOffert)
                };
                // Ajout du rapport dans la liste gérees par le programme
                monModele.offrirs.Add(unEchantillon);
                // Sauvegarde de l'ajout dans la BDD
                monModele.SaveChanges(); 
                MessageBox.Show("Nouvel échantillon de " + medOffert + ".", "Ajout confirmé", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erreur de format, reessayez.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /*
            Form_Echantillon_Offrir f = new Form_Echantillon_Offrir();
            if(f.ShowDialog() == DialogResult.OK) {
                medOffert = f.Input;
                qtOffert = f.Input2;
                MessageBox.Show("Le médicament " + medOffert + " et la quantité " + qtOffert);
                var trouverDepotLegal = from p in monModele.medicaments
                                                where p.MED_NOMCOMMERCIAL== medOffert
                                                select p.MED_DEPOTLEGAL;
                foreach(var res in trouverDepotLegal)
                {
                    depotLegal = res;
                }
                
                // Maintenant il faut les afficher dans le datagridview
                dgvMedicament.Rows.Add(medOffert, qtOffert);
                */

        }
    }
    
}
