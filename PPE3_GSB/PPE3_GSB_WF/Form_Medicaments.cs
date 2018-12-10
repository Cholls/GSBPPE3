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
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet5.medicament'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medicamentTableAdapter.Fill(this.gSB_PPE3DataSet5.medicament);

        }

        private void bt_valid_Click(object sender, EventArgs e)
        {
            string selection = cb_select.SelectedValue.ToString();
            var req = from p in monModele.medicaments
                      where p.MED_NOMCOMMERCIAL == selection
                      select p;
            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                tb_nom.Text = resultat.MED_NOMCOMMERCIAL;
                tb_depot.Text = resultat.MED_DEPOTLEGAL;
                tb_compo.Text = resultat.MED_COMPOSITION;
                tb_effet.Text = resultat.MED_EFFETS;
                tb_contre.Text = resultat.MED_CONTREINDIC;
            }
        }
    }
}
