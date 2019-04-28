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
using PPE3_GSB_WF.UI;

namespace PPE3_GSB_WF
{
    public partial class Form_Rapports_Visiteur : Form
    {
        private GSB_PPE3Entities1 monModele;
        string yearmp;
        string monthmp;
        int mois;
        int annee;
        int jour;
        DateTime datecomplete;
        private List<string> lesMois;
        private List<string> lesDates;
        private List<string> lesJours;

        public Form_Rapports_Visiteur()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Se déclenche au chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Rapports_Visiteur_Load(object sender, EventArgs e)
        {
            // Récupération de l'année d'une date trouvée dans les rapports de visites
            var req4 = from p in monModele.rapport_visite
                      where p.visiteur.VIS_NOM == labelNom.Text
                      select p.RAP_DATE_SAISIE;
            // Ajout des dates des rapports dans le comboBox
            

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

        // Rempli tous les textBox selon le rapport sélectionné
        private void Bt_valid_Click(object sender, EventArgs e)
        {
            dgvMedicamentPremier.Rows.Clear();
            string nomDuPraticien;
            string motif;
            //string matricule;

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
                    tb_num.Text = Convert.ToString(resultat.RAP_NUM);
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

        // Permet d'ouvrir le formulaire permettant de créer un rapport
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Il faut donner le nom du visiteur au formulaire
            // Pour savoir à quel visiteur ajouter le rapport
            Form_Rapport_Ajouter f = new Form_Rapport_Ajouter();
            // Passe le nom du visiteur 
            f.tb_nomVis.Text = labelNom.Text;
            f.Show();
        }


        // Quand une année est sélectionnée dans le combobox des années
        private void cb_annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_mois.Items.Clear();
            cb_mois.Enabled = true;
            annee = Convert.ToInt32(cb_annee.Text);
            var recupMois = from p in monModele.rapport_visite
                            where p.visiteur.VIS_NOM == labelNom.Text
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

        // Permet d'afficher le jour après avoir sélectionné le mois 
        private void cb_mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_jour.Items.Clear();
            cb_jour.Enabled = true;
            mois = Convert.ToInt32(cb_mois.Text);
            var recupJour = from p in monModele.rapport_visite
                            where p.visiteur.VIS_NOM == labelNom.Text
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

        // Quand le jour est sélectionné, il faut maintenant sélectionner les numéros de rapports
        // correspondant au visiteur ET à la date complète sélectionnée
        private void cb_jour_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_CR.Items.Clear();
            cb_CR.Enabled = true;
            jour = Convert.ToInt32(cb_jour.Text);
            datecomplete = new DateTime(annee, mois, jour);

            var recupCR = from p in monModele.rapport_visite
                          where p.visiteur.VIS_NOM == labelNom.Text
                          where p.RAP_DATE_SAISIE == datecomplete
                          select p.RAP_NUM;

            foreach(var res in recupCR)
            {
                cb_CR.Items.Add(res);
            }
        }
    }
}
