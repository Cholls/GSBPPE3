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
        string identSuper = "gsbadmin";
        string mdpSuper = "mdp";

        public Form_Accueil()
        {
            InitializeComponent();
        }


        public void DesactiverMenu()
        {
            mnu_Visiteurs.Enabled = false;
            mnu_Medicaments.Enabled = false;
            mnu_Medecins.Enabled = false;
        }


        private void Form_Accueil_Load(object sender, EventArgs e)
        {
            Form_Connexion seConnecte = new Form_Connexion();
            if(seConnecte.getIdent() == identSuper && seConnecte.getMdp() == mdpSuper)
            {
                DesactiverMenu();
            }
            
            seConnecte.ShowDialog();
        }

 
        private void ajouterUnVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Visiteurs_Ajouter fva = new Form_Visiteurs_Ajouter();
            fva.Show();
        }

        private void visualiserLesVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Visiteurs fv = new Form_Visiteurs();
            fv.MdiParent = this;
            fv.Show();
        }

        private void ajouterUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ici on ajoutera le code pour ouvrir la fenêtre permettant de créer un rapport
        }

        private void visualiserLesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ici on ajoutera le code pour ouvrir la fenêtre permettant de visualiser un rapport
        }

        private void ajouterUnMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ici on ajoutera le code pour ouvrir la fenêtre permettant d'ajouter un médicament
        }

        private void visualiserLesMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Medicaments fv = new Form_Medicaments();
            fv.MdiParent = this;
            fv.Show();
        }

        private void ajouterUnMédecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Medecins_Ajouter fva = new Form_Medecins_Ajouter();
            fva.Show();
        }

        private void visualiserLesMedecintoolTip_Click(object sender, EventArgs e)
        {
            Form_Medecins fva = new Form_Medecins();
            fva.MdiParent = this;
            fva.Show();
        }
    }
}
