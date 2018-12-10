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
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet4.visiteurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.visiteursTableAdapter1.Fill(this.gSB_PPE3DataSet4.visiteurs);
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet.visiteurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.


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

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {

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
            string selection = cb_select.SelectedValue.ToString();
            var req = from p in monModele.visiteurs
                      where p.VIS_NOM == selection
                      select p;
            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                tb_num.Text = Convert.ToString(resultat.VIS_MATRICULE);
                tb_nom.Text = resultat.VIS_NOM;
                tb_prenom.Text = resultat.VIS_PRENOM;
                tb_adresse.Text = resultat.VIS_ADRESSE;
                tb_cp.Text = resultat.VIS_CP;
                tb_ville.Text = resultat.VIS_VILLE;
                tb_dateEmbauche.Text = Convert.ToString(resultat.VIS_DATEEMBAUCHE);
            }
        }
    }
}
