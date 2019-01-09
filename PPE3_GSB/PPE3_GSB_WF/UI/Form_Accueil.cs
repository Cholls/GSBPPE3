using PPE3_GSB_WF.Accès_aux_données;
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
 
        private GSB_PPE3Entities1 monModele;
        Form_Connexion seConnecte;
        public Form_Accueil()
        {
            InitializeComponent();
            seConnecte = new Form_Connexion();
            monModele = new GSB_PPE3Entities1();

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

        /// <summary>
        /// Fait en sorte que si un formulaire est déjà ouvert, on le ferme pour ouvrir le nouveau
        /// </summary>
        public void FermerMDI()
        {
            Form c;
            c = this.ActiveMdiChild;
            if (c != null)
                c.Close();
        }

        private void Form_Accueil_Load(object sender, EventArgs e)
        {
            
            // LE PROBLEME DU PASSAGE MEME DANS LE FALSE NE VIENT PAS DES LIGNES SUIVANTES
            if (seConnecte.ShowDialog() == DialogResult.OK)
            {
                string util = seConnecte.Input;
                if(util == "V") { // Si un visiteur est connecté
                    DesactiverMenu();
                    visualSecretaria.Visible = false;
                    visualVisiteur.Visible = true;
                    string leLogin = seConnecte.tb_Identifiant.Text;

                    var req1 = from v in monModele.visiteurs
                               where v.VIS_LOGIN == leLogin
                               select v;
                    foreach(var resultat in req1)
                    {
                        // Récupération du prénom et du nom du visiteur actuellement connecté
                        labelPrenom.Text = resultat.VIS_PRENOM;
                        labelNom.Text = resultat.VIS_NOM;
                    }
                }
                else if(util == "S"){ // Si un super utilisateur est connecté
                    //MessageBox.Show("Super utilisateur connecté !");
                    visualSecretaria.Visible = true;
                    visualVisiteur.Visible = false;
                    labelPrenom.Text = "";
                    labelNom.Text = "";
                    label1.Text = "Bienvenue, compte réservé à l'administration";
                }
                else
                {
                    // Solution pour que l'application reprenne quand une identification est mauvaise
                    MessageBox.Show("Erreur connexion, mauvais identifiant et/ou mot de passe ou champ(s) vide(s). Reessayer.");
                    seConnecte.ShowDialog();
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
            FermerMDI();
            Form_Visiteurs fv = new Form_Visiteurs();
            fv.MdiParent = this;
            fv.Show();
        }

        private void ajouterUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ici on ajoutera le code pour ouvrir la fenêtre permettant de créer un rapport
        }

        // Ici ouvrir la page de rapport du secrétaria
        private void visualiserLesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
            Form_Rapports_Secretaria f = new Form_Rapports_Secretaria();
            f.MdiParent = this;
            f.Show();
        }

        // Ici ouvrir la page de rapport du visiteur
        private void visualVisiteur_Click(object sender, EventArgs e)
        {
            FermerMDI();
            Form_Rapports_Visiteur f = new Form_Rapports_Visiteur();
            f.MdiParent = this;
            // Récupération du nom et du prénom du visiteur sur les labels de l'accueil
            f.labelNom.Text = labelNom.Text;
            f.labelPrenom.Text = labelPrenom.Text;
            f.Show();
        }

        private void ajouterUnMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Medicament_Ajouter fa = new Form_Medicament_Ajouter();
            fa.Show();

        }

        private void visualiserLesMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerMDI();
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
            FermerMDI();
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
            //Ne fonctionne pas encore, ne ferme pas la fenêtre de l'accueil
            //this.Close();
            //seConnecte.ShowDialog();
            
            
        }
    }
}
