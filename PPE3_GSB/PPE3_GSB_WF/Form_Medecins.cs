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
        public Form_Medecins()
        {
            InitializeComponent();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Medecins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet2.praticien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.praticienTableAdapter1.Fill(this.gSB_PPE3DataSet2.praticien);
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet1.praticien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.praticienTableAdapter.Fill(this.gSB_PPE3DataSet1.praticien);
            // TODO: cette ligne de code charge les données dans la table 'eCOLECONDUITEDataSet.ELEVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eLEVETableAdapter.Fill(this.eCOLECONDUITEDataSet.ELEVE);

        }
    }
}
