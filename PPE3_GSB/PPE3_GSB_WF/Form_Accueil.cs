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
    public partial class Form_Accueil : Form
    {
        public Form_Accueil()
        {
            InitializeComponent();
        }

        private void Form_Accueil_Load(object sender, EventArgs e)
        {
            Form_Connexion seConnecte = new Form_Connexion();
            seConnecte.ShowDialog();
        }

        private void visiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Visiteurs fv = new Form_Visiteurs();
            fv.MdiParent = this;
            fv.Show();
        }

        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Rapports fr = new Form_Rapports();
            fr.MdiParent = this;
            fr.Show();
        }

        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Medicaments fm = new Form_Medicaments();
            fm.MdiParent = this;
            fm.Show();
        }

        private void medecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Medecins fd = new Form_Medecins();
            fd.MdiParent = this;
            fd.Show();
        }
    }
}
