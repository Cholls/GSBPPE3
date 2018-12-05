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
        public Form_Visiteurs()
        {
            InitializeComponent();
        }

        private void Form_Visiteurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet4.visiteurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.visiteursTableAdapter1.Fill(this.gSB_PPE3DataSet4.visiteurs);
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet.visiteurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.


        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
