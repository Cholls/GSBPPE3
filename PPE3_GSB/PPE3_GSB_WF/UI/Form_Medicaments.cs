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
    public partial class Form_Medicaments : Form
    {
        private GSB_PPE3Entities1 monModele;
        public Form_Medicaments()
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

        private void Form_Medicaments_Load(object sender, EventArgs e)
        {

            // dans le combobox sans utiliser un binding pointant sur la base de données
            var req = from m in monModele.medicaments
                      select m.MED_NOMCOMMERCIAL;

            foreach (var resultat in req)
            {
                cb_select.Items.Add(resultat);
            }

        }

        private void bt_valid_Click(object sender, EventArgs e)
        {
            // Bouton cliqué, donc on peut activer les champs 
            // correspondant aux différents attributs
            tb_nom.ReadOnly = false;
            tb_compo.ReadOnly = false;
            tb_contre.ReadOnly = false;
            tb_effet.ReadOnly = false;
            //tb_famille.ReadOnly = false;


            // Pour récupérer la valeur dans le comboBox
            string selection = cb_select.SelectedItem.ToString();
            var req = from p in monModele.medicaments
                      where p.MED_NOMCOMMERCIAL == selection
                      select p;
            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                tb_nom.Text = resultat.MED_NOMCOMMERCIAL;
                tb_compo.Text = resultat.MED_COMPOSITION;
                tb_effet.Text = resultat.MED_EFFETS;
                tb_contre.Text = resultat.MED_CONTREINDIC;
                tb_famille.Text = resultat.FAM_CODE;
                
            }
        }

        /// <summary>
        /// Ouvre la fenêtre d'ajout de médicaments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            Form_Medicament_Ajouter fa = new Form_Medicament_Ajouter();
            fa.Show();
        }
    }
}
