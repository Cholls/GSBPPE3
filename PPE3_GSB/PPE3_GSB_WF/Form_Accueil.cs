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

        /// <summary>
        /// Rend inaccessible les menus visiteurs, médicaments et médecins
        /// 
        /// </summary>
        public void DesactiverMenu()
        {
            mnu_Visiteurs.Enabled = false;
            mnu_Medicaments.Enabled = false;
            mnu_Medecins.Enabled = false;
        }


        private void Form_Accueil_Load(object sender, EventArgs e)
        {
            Form_Connexion seConnecte = new Form_Connexion();
           // seConnecte.ShowDialog();
            if (seConnecte.ShowDialog() == DialogResult.OK)
            {
                string util = seConnecte.Input;
                if(util == "V") { // Si un visiteur est connecté
                    DesactiverMenu();
                }
                else if(util == "S"){ // Si un super utilisateur est connecté
                    //MessageBox.Show("Super utilisateur connecté !");
                }
            }
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
            Form_Medicament_Ajouter fa = new Form_Medicament_Ajouter();
            fa.Show();

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

        /// <summary>
        /// Permet de déclencher la déconnexion, faisant revenir à la fenêtre de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ne fonctionne pas encore, ne ferme pas la fenêtre de l'accueil
            Form_Connexion seConnecte = new Form_Connexion();
            seConnecte.ShowDialog();
            
        }
    }
}
