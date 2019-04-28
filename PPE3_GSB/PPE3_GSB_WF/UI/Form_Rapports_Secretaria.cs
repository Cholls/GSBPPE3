using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3_GSB_WF.Accès_aux_données;

namespace PPE3_GSB_WF
{
    public partial class Form_Rapports_Secretaria : Form
    {
        private GSB_PPE3Entities1 monModele;
        private string recupRegCode;
        private Point mouseLocation;
        private int annee;
        private string yearmp;
        private int mois;
        private int jour;
        private DateTime datecomplete;
        private List<string> lesDates;
        private List<string> lesMois;
        private List<string> lesJours;

        public Form_Rapports_Secretaria()
        {
            monModele = new GSB_PPE3Entities1();
            InitializeComponent();
        }

        /// <summary>
        /// Action se produisant au chargement de la fenêtre des rapports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Rapports_Secretaria_Load(object sender, EventArgs e)
        {
            // Pré-rempli la combobox des régions des visiteurs
            RechargerDonneescb();

            dgvMedicamentPremier.ColumnCount = 2;
            dgvMedicamentPremier.ColumnHeadersVisible = true;
            dgvMedicamentPremier.Columns[0].Name = "Nom du médicament";
            dgvMedicamentPremier.Columns[1].Name = "Quantité offerte";
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RechargerDonneescb()
        {
            // Récupère les régions dans la base de données
            var req = from v in monModele.regions
                      select v;

            foreach (var resultat in req)
            {
                cb_region.Items.Add(resultat.REG_NOM);
            }
        }

        // A la selection d'une région, recherche des visiteurs associés à cette région
        // et affichage dans une combobox
        private void cb_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nettoie ce qui est déjà dans la comboBox
            // Si une recherche a déjà été faite
            cb_select.Items.Clear();

            // Récupère la sélection du premier comboBox (de la région)
            string selection = cb_region.SelectedItem.ToString();

            // Requête pour récupérer le code de la région
            // de la région sélectionnée dans le premier combobox
            var recupCode = from p in monModele.regions
                            where p.REG_NOM == selection
                            select p.REG_CODE;

            // Récupération du code de la région
            foreach (var resultat in recupCode)
            {
                recupRegCode = resultat;
            }

            // Récupération des visiteurs étant dans la région sélectionnée dans le comboBox
            var vis = from p in monModele.visiteurs
                      where p.REG_CODE == recupRegCode
                      select p.VIS_NOM;

            foreach (var resultat in vis)
            {
                cb_select.Items.Add(resultat);
            }
        }

        // Permet de savoir quel visiteur consulter, détermine les autres contenus des autres comboBox
        private void button3_Click(object sender, EventArgs e)
        {
            cb_CR.Items.Clear();
            
            //string test = "";
            // Récupère la saisie du textbox
            string saisie = tb_recherche.Text;


            // Faire la requête pour savoir si le nom saisie correspond à un nom dans la bdd
            var req = from v in monModele.visiteurs
                      where v.VIS_NOM == saisie
                      select v;

            // Parcours de la requête
            foreach (var res in req)
            {
                // Vérification si le nom saisie correspond pour un nom dans la bdd
                if (saisie == res.VIS_NOM)
                {
                    Label_NOM.Text = res.VIS_NOM;
                    labelPrenom.Text = res.VIS_PRENOM;

                    // Mettre une date 
                    cb_annee.Enabled = true;

                    // Récupération de l'année d'une date trouvée dans les rapports de visites
                    var req4 = from p in monModele.rapport_visite
                               where p.visiteur.VIS_NOM == Label_NOM.Text
                               select p.RAP_DATE_SAISIE;

                    lesDates = new List<string>();

                    // Ajout des dates des rapports dans le comboBox
                    foreach (var resultat in req4)
                    {
                        lesDates.Add(Convert.ToString(resultat.Value.ToString("yyyy")));

                    }
                    // Faire cette liste pour enlever les doublons, si par exemple on a récupéré deux fois 2019
                    IEnumerable<string> sansDoublons = lesDates.Distinct();
                    foreach (string trueDate in sansDoublons)
                    {
                        cb_annee.Items.Add(trueDate);
                    }
                }
                else
                {
                    // Si non, afficher message d'erreur
                    MessageBox.Show("Erreur, ce visiteur n'existe pas dans la base de données.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }      
        }


        /// <summary>
        /// Sert à délencher l'affichage des dates dans le combobox cb_date
        /// (les rapports détécté pour le visiteur choisi)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Si une recherche a déjà été faite, il faut vider les comboBox et les textbox
            cb_annee.Items.Clear();
            cb_jour.Items.Clear();
            cb_CR.Items.Clear();
            cb_mois.Items.Clear();
            tb_bilan.Text = "";
            tb_dateSaisie.Text = "";
            tb_dateVisite.Text = "";
            tb_motif.Text = "";
            tb_prac.Text = "";
            tb_num.Text = "";

            if (cb_select.Text == "")
            {
                MessageBox.Show("Aucune sélection, attention !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try // Faire un bloc try catch au cas où une erreur pourrait survenir 
                    // quand un visiteur n'est pas dans la région sélectionnée
                {                  
                    // Récupération du contenu du combobox 
                    string nom = cb_select.SelectedItem.ToString();

                    var req = from p in monModele.visiteurs
                              where p.VIS_NOM == nom
                              select p;

                    // Afficher le nom et le prénom du visiteur sélectionné
                    foreach (var resultat in req)
                    {
                        MessageBox.Show("Visiteur trouvé dans la base !", "Réussite");
                        Label_NOM.Text = resultat.VIS_NOM;
                        labelPrenom.Text = resultat.VIS_PRENOM;
                    }
                    MessageBox.Show("Chargement du visiteur sélectionné : " + cb_select.Text);
                    cb_annee.Enabled = true;

                    // Récupération de l'année d'une date trouvée dans les rapports de visites
                    var req4 = from p in monModele.rapport_visite
                               where p.visiteur.VIS_NOM == Label_NOM.Text
                               select p.RAP_DATE_SAISIE;

                    lesDates = new List<string>();
 
                    // Ajout des dates des rapports dans le comboBox
                    foreach (var resultat in req4)
                    {
                        lesDates.Add(Convert.ToString(resultat.Value.ToString("yyyy")));
 
                    }
                    // Faire cette liste pour enlever les doublons, si par exemple on a récupéré deux fois 2019
                    IEnumerable<string> sansDoublons = lesDates.Distinct();
                    foreach (string trueDate in sansDoublons)
                    {
                        cb_annee.Items.Add(trueDate);
                    }

                    // Partie pour les échantillons de médicaments offerts
                    // -----------------------------------------------------------
                    // Afficher les informations dans la table offrir concernant 

                    int numRapport = Convert.ToInt32(tb_num.Text);
                    // Rechercher les lignes de la table offrir correspondant au numéro de dossier
                    var req3 = from r in monModele.offrirs
                               where r.RAP_NUM == numRapport
                               select r;
                    string depotLegal;
                    foreach (var resultat1 in req3)
                    {
                        depotLegal = resultat1.MED_DEPOTLEGAL;
                        //dgvMedicamentPremier.Rows.Add(resultat1.MED_DEPOTLEGAL, resultat1.OFF_QTE);
                        // Affichage des données des médicaments offerts dans le datagridview des médicaments
                        var retrouverMed = from r in monModele.medicaments
                                           where r.MED_DEPOTLEGAL == depotLegal
                                           select r;
                        foreach (var med in retrouverMed)
                        {
                            dgvMedicamentPremier.Rows.Add(med.MED_NOMCOMMERCIAL, resultat1.OFF_QTE);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Erreur. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cb_select.Items.Clear();
                }catch (FormatException)
                {
                    MessageBox.Show("Erreur. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
       

        // Quand une année est sélectionnée dans le combobox des années
        private void cb_annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cb_mois.Items.Clear();
                cb_mois.Enabled = true;
                annee = Convert.ToInt32(cb_annee.Text);
                var recupMois = from p in monModele.rapport_visite
                                where p.visiteur.VIS_NOM == Label_NOM.Text
                                where p.RAP_DATE_SAISIE.Value.Year == annee
                                select p.RAP_DATE_SAISIE.Value.Month;

                lesMois = new List<string>();

                // Ajout des dates des rapports dans le comboBox
                foreach (var resultat in recupMois)
                {
                    lesMois.Add(Convert.ToString(resultat));

                }
                // Faire cette liste pour enlever les doublons, si par exemple on a récupéré deux fois 2019
                IEnumerable<string> sansDoublons = lesMois.Distinct();
                foreach (string trueDate in sansDoublons)
                {
                    cb_mois.Items.Add(trueDate);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Erreur de format...", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Quand la combobox des mois est sélectionné, il faut activer la sélection des jours
        private void cb_mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_jour.Items.Clear();
            cb_jour.Enabled = true;
            mois = Convert.ToInt32(cb_mois.Text);
            var recupJour = from p in monModele.rapport_visite
                            where p.visiteur.VIS_NOM == Label_NOM.Text
                            where p.RAP_DATE_SAISIE.Value.Month == mois
                            select p.RAP_DATE_SAISIE.Value.Day;

            lesJours = new List<string>();

            // Ajout des dates des rapports dans le comboBox
            foreach (var resultat in recupJour)
            {
                lesJours.Add(Convert.ToString(resultat));

            }
            // Faire cette liste pour enlever les doublons, si par exemple on a récupéré deux fois 2019
            IEnumerable<string> sansDoublons = lesJours.Distinct();
            foreach (string trueDate in sansDoublons)
            {
                cb_jour.Items.Add(trueDate);
            }
            
        }

        private void cb_jour_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_CR.Items.Clear();
            cb_CR.Enabled = true;
            jour = Convert.ToInt32(cb_jour.Text);
            datecomplete = new DateTime(annee, mois, jour);


            var recupCR = from p in monModele.rapport_visite
                          where p.visiteur.VIS_NOM == Label_NOM.Text
                          where p.RAP_DATE_SAISIE == datecomplete
                          select p.RAP_NUM;

            foreach (var res in recupCR)
            {
                cb_CR.Items.Add(res);
            }
        }

        // Validation finale après la sélection du numéro du rapport 
        private void bt_valid_Click_1(object sender, EventArgs e)
        {
            dgvMedicamentPremier.Rows.Clear();
            string nomDuPraticien;
            string motif;

            try
            {
                // Récupération du contenu du combobox 
                int selection = Convert.ToInt32(cb_CR.SelectedItem.ToString());

                var req = from r in monModele.rapport_visite
                          where r.RAP_NUM == selection
                          select r;

                // Remplissage des textBox grâce à la requête
                foreach (var resultat in req)
                {
                    tb_num.Text = Convert.ToString(resultat.PRA_NUM);
                    tb_bilan.Text = resultat.RAP_BILAN;
                    tb_dateSaisie.Text = Convert.ToString(resultat.RAP_DATE_SAISIE.Value.ToString("yyyy-MM-dd"));
                    tb_dateVisite.Text = Convert.ToString(resultat.RAP_DATE_VISITE.Value.ToString("yyyy-MM-dd"));
                    // Récupération du nom du praticien attaché au rapport
                    nomDuPraticien = resultat.praticien.PRA_NOM;
                    tb_prac.Text = nomDuPraticien;
                    // Récupération du labelle du motif attaché au rapport
                    motif = resultat.motif.MOT_LIBELLE;
                    tb_motif.Text = motif;
                }

                // Partie pour les échantillons de médicaments offerts
                // -----------------------------------------------------------
                // Afficher les informations dans la table offrir concernant 

                int numRapport = Convert.ToInt32(tb_num.Text);
                // Rechercher les lignes de la table offrir correspondant au numéro de dossier
                var req3 = from r in monModele.offrirs
                           where r.RAP_NUM == numRapport
                           select r;
                string depotLegal;
                foreach (var resultat1 in req3)
                {
                    depotLegal = resultat1.MED_DEPOTLEGAL;
                    //dgvMedicamentPremier.Rows.Add(resultat1.MED_DEPOTLEGAL, resultat1.OFF_QTE);
                    // Affichage des données des médicaments offerts dans le datagridview des médicaments
                    var retrouverMed = from r in monModele.medicaments
                                       where r.MED_DEPOTLEGAL == depotLegal
                                       select r;
                    foreach (var med in retrouverMed)
                    {
                        dgvMedicamentPremier.Rows.Add(med.MED_NOMCOMMERCIAL, resultat1.OFF_QTE);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Aucune sélection, attention !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

   
    }
}
