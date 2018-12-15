using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_GSB_WF
{
    public partial class Form_Visiteurs : Form
    {
        private GSB_PPE3Entities1 monModele;
        public Form_Visiteurs()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        private void Form_Visiteurs_Load(object sender, EventArgs e)
        {
            // dans le combobox sans utiliser un binding pointant sur la base de données
            var req = from v in monModele.visiteurs
                      select v.VIS_NOM;

            foreach (var resultat in req)
            {
                cb_select.Items.Add(resultat);
            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Visiteurs_Ajouter fva = new Form_Visiteurs_Ajouter();
            fva.Show();
        }


        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Form_Visiteurs_Modifier fvm = new Form_Visiteurs_Modifier();
            fvm.Show();
        }


        /// <summary>
        /// Pour afficher les informations d'un visiteur sélectionner
        /// dans un comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {

            // Bouton cliqué, donc on peut activer les champs 
            // correspondant aux différents attributs
            tb_nom.ReadOnly = false;
            tb_prenom.ReadOnly = false;
            tb_cp.ReadOnly = false;
            tb_ville.ReadOnly = false;
            tb_adresse.ReadOnly = false;
            tb_dateEmbauche.ReadOnly = false;

            // Récupération du contenu du combobox 
            string selection = cb_select.SelectedItem.ToString();

            var req = from p in monModele.visiteurs
                      where p.VIS_NOM == selection
                      select p;

            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                tb_nom.Text = resultat.VIS_NOM;
                tb_prenom.Text = resultat.VIS_PRENOM;
                tb_adresse.Text = resultat.VIS_ADRESSE;
                tb_cp.Text = resultat.VIS_CP;
                tb_ville.Text = resultat.VIS_VILLE;
                tb_dateEmbauche.Text = Convert.ToString(resultat.VIS_DATEEMBAUCHE);
            }
        }

        /// <summary>
        /// Permet de prendre en compte les modifications faites
        /// aux différents champs du visiteur sélectionné par 
        /// la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string selection = cb_select.SelectedValue.ToString();
            var vis = from p in monModele.visiteurs
                      where p.VIS_NOM == selection
                      select p;

            foreach (var resultat in vis)
            {
                resultat.VIS_NOM = tb_nom.Text;
                resultat.VIS_NOM = tb_nom.Text;
                resultat.VIS_PRENOM = tb_prenom.Text;
                resultat.VIS_ADRESSE = tb_adresse.Text;
                resultat.VIS_CP = tb_cp.Text;
                resultat.VIS_VILLE = tb_ville.Text;
                //resultat.VIS_DATEEMBAUCHE = Convert.ToDateTime(tb_dateEmbauche);
            }
            // Faire une vérif si une modification a lieu 
            MessageBox.Show("Les données ont bien été modifiées !");

            // Reperer comment faire le SavesChanges
            monModele.SaveChanges();

        }

        // Essai pour empêcher de valider si la valeur du comboBox n'a pas changé
        // FONCTIONNE MAIS ON PEUT QUAND MEME NE RIEN RENTRER ET VALIDER
        // FAIRE EN SORTE QU'ON NE PUISSE PAS QUAND MEME tant que vide 
        private void cb_select_TextChanged(object sender, EventArgs e)
        {
            bt_valid.Enabled = true;
        }

        private void cb_select_MouseClick(object sender, MouseEventArgs e)
        {
            bt_valid.Enabled = true;
        }
    }
}
