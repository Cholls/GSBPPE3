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
            // LIGNES PEUT-ËTRE A SUPPRIMER
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet2.praticien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.praticienTableAdapter1.Fill(this.gSB_PPE3DataSet2.praticien);
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet1.praticien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.praticienTableAdapter.Fill(this.gSB_PPE3DataSet1.praticien);

        }

        /// <summary>
        /// Fait afficher les données d'un médécin en autorisant la modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
           
        }

   
        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Medecins_Ajouter fva = new Form_Medecins_Ajouter();
            fva.Show();
        }

        /// <summary>
        /// Permet de sélectionner un praticien parmi la liste du combobox
        /// Ce qui a pour effet de remplir les textbox sur le côté 
        /// (les informations du médecin sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string selection = cb_Select.SelectedValue.ToString();
            var req = from p in monModele.praticiens
                      where p.PRA_NOM == selection
                      select p;
            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                tb_num.Text = Convert.ToString(resultat.PRA_NUM);
                tb_nom.Text = resultat.PRA_NOM;
                tb_prenom.Text = resultat.PRA_PRENOM;
                tb_adresse.Text = resultat.PRA_ADRESSE;
                tb_cp.Text = resultat.PRA_CP;
                tb_ville.Text = resultat.PRA_VILLE;
                tb_coefNot.Text = Convert.ToString(resultat.PRA_COEFNOTORIETE);
                tb_coefConf.Text = Convert.ToString(resultat.PRA_COEFCONFIANCE);
                tb_spe.Text = resultat.TYP_CODE;
            }
        }
    }
}
