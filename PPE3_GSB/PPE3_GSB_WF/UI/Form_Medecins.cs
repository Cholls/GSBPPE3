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
    public partial class Form_Medecins : Form
    {
        private GSB_PPE3Entities1 monModele;
        public Form_Medecins()
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

        private void Form_Medecins_Load(object sender, EventArgs e)
        {
            // Charge les médecins dans le ComboBox
            // dans le combobox sans utiliser un binding pointant sur la base de données
            var req = from p in monModele.praticiens
                      select p.PRA_NOM;

            foreach (var resultat in req)
            {
                cb_Select.Items.Add(resultat);
            }
        }

   
        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Medecins_Ajouter fva = new Form_Medecins_Ajouter();
            fva.Show();
        }

        /// <summary>
        /// Permet de sélectionner un praticien parmi la liste du combobox
        /// Ce qui a pour effet de remplir les textbox sur le côté 
        /// (les informations du médecin sélectionnées)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Bouton cliqué, donc on peut activer les champs 
            // correspondant aux différents attributs
            tb_nom.ReadOnly = false;
            tb_prenom.ReadOnly = false;
            tb_cp.ReadOnly = false;
            tb_ville.ReadOnly = false;
            tb_adresse.ReadOnly = false;
            tb_coefConf.ReadOnly = false;
            tb_coefNot.ReadOnly = false;
            tb_coefNot.ReadOnly = false;
            tb_type.ReadOnly = false;

            // Récupération du contenu du combobox 
            string selection = cb_Select.SelectedItem.ToString();

            var req = from p in monModele.praticiens
                      where p.PRA_NOM == selection
                      select p;

            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                tb_nom.Text = resultat.PRA_NOM;
                tb_prenom.Text = resultat.PRA_PRENOM;
                tb_adresse.Text = resultat.PRA_ADRESSE;
                tb_cp.Text = resultat.PRA_CP;
                tb_ville.Text = resultat.PRA_VILLE;
                tb_coefNot.Text = Convert.ToString(resultat.PRA_COEFNOTORIETE);
                tb_coefConf.Text = Convert.ToString(resultat.PRA_COEFCONFIANCE);
                tb_type.Text = resultat.TYP_CODE;
            }
        }

        /// <summary>
        /// Permet de modifier dans la base de données
        /// les informations du médecin choisi
        /// (Avec dans la requête where médecin choisi)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            
            string selection = cb_Select.SelectedValue.ToString();
            var med = from p in monModele.praticiens
                      where p.PRA_NOM == selection
                      select p;

            foreach (var resultat in med)
            {
                resultat.PRA_NOM = tb_nom.Text;
                resultat.PRA_PRENOM = tb_prenom.Text;
                resultat.PRA_ADRESSE = tb_adresse.Text;
                resultat.PRA_CP = tb_cp.Text;
                resultat.PRA_VILLE = tb_ville.Text;
            }

            // Faire une vérif si une modification a lieu 
            MessageBox.Show("Les données ont bien été modifiées !");

            // Reperer comment faire le SavesChanges
            monModele.SaveChanges();

         
        }

        
    }
}
