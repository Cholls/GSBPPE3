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
    
        public string Nom
        {
            get { return labelNom.Text; }
        }

        
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
            // au chargement du formulaire, il faut remplir le comboBox 
            // avec les rapports du visiteur connecté
            var req = from p in monModele.rapport_visite
                      where p.visiteur.VIS_NOM == labelNom.Text
                      select p.RAP_DATE_SAISIE;

            // Ajout des dates des rapports dans le comboBox
            foreach (var resultat in req)
            {
                cb_select.Items.Add(resultat);
            }
        }

        // Rempli tous les textBox selon le rapport sélectionné
        private void Bt_valid_Click(object sender, EventArgs e)
        {
            string nomDuPraticien;
            string motif;
            int matricule;
            // Récupération du contenu du combobox 
            DateTime selection = Convert.ToDateTime(cb_select.SelectedItem.ToString());

            var req = from r in monModele.rapport_visite
                      where r.RAP_DATE_SAISIE == selection
                      select r;

            // Remplissage des textBox grâce à la requête
            foreach (var resultat in req)
            {
                tb_num.Text = Convert.ToString(resultat.RAP_NUM);
                tb_bilan.Text = resultat.RAP_BILAN;
                tb_dateSaisie.Text = Convert.ToString(resultat.RAP_DATE_SAISIE);
                tb_dateVisite.Text = Convert.ToString(resultat.RAP_DATE_VISITE);
            }
            foreach (var resultat in req)
            {
                // Récupération du nom du praticien attaché au rapport
                nomDuPraticien = resultat.praticien.PRA_NOM;
                tb_prac.Text = nomDuPraticien;
                // Récupération du labelle du motif attaché au rapport
                motif = resultat.motif.MOT_LIBELLE;
                tb_motif.Text = motif;
            }

            // Récupération du numéro du rapport
            matricule = Convert.ToInt32(tb_num.Text);

            var req3 = from r in monModele.offrirs
                       where r.RAP_NUM == matricule
                       select r;

            string matriculeMedicament;

            foreach (var resultat in req3)
            {
                

            }
        }

        /// <summary>
        /// Ouverture du formulaire de création d'un nouveau rapport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form_Rapport_Ajouter fa = new Form_Rapport_Ajouter();
            fa.Show();
        }
    }
}
