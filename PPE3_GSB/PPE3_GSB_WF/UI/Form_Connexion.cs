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
    public partial class Form_Connexion : Form
    {
        string identSuper = "test";
        string mdpSuper = "test";
        string utilisateur = "";
        string mdpVisiteur;
        string identVisiteur;

        // LES DEUX PROCHAINES METHODES SERVENT A SAVOIR QUI EST CONNECTE
        // POUR DONNER A LA FENETRE DU RAPPORT DE VISITEUR
        /// <summary>
        /// Récupération de l'identification du visiteur
        /// </summary>
        public string InputIdent
        {
            get { return identVisiteur; }
        }

        /// <summary>
        /// Récupération du mdp du visiteur
        /// </summary>
        public string InputMdp
        {
            get { return mdpVisiteur; }
        }

        /// <summary>
        /// Pour récupérer la variable
        /// utilisateur qui nous permet de savoir qui est connecté
        /// V pour visiteur et S pour super utilisateur
        /// // Cette variable va être récupérée par accueil
        /// </summary>
        /// <returns></returns>
        public string Input
        {
            get { return utilisateur; }
        }

        private GSB_PPE3Entities1 monModele;
        public Form_Connexion()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        public string LeNomVisiteur
        {
            get { return tb_Identifiant.Text; }
        }


        /// <summary>
        /// Fermeture du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer l'application ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        /// <summary>
        /// Tous les tests de connexion et le passage des variables de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            // Ici, vérifier qui se connecte :
            // Si c'est un visiteur, n'afficher que l'onglet des rapports
            // Si c'est un délegué régional, il voit les rapports et les visiteurs de sa région
            // Si c'est une personne chargée de la gestion, elle peut tout voir
         
            // Voir pour crypter les mdp dans le futur proche
            mdpVisiteur = tb_MotDePasse.Text;
            identVisiteur = tb_Identifiant.Text;
                
            //TEST CONNEXION DES VISITEURS
            //Parcourir la liste des logins et des mot de passes des visiteurs
            var req1 = from v in monModele.visiteurs
                       where v.VIS_LOGIN == identVisiteur
                       && v.VIS_MDP == mdpVisiteur
                      select v;
 
            bool estValide = false;
            foreach (var resultat in req1)
            {
                // Vérification de la correspondance
                // Voir comment faire pour réussir l'autentification
                if ((mdpVisiteur == resultat.VIS_MDP) && (identVisiteur == resultat.VIS_LOGIN)) {
                    estValide = true;
                    MessageBox.Show("Visiteur : Connexion réussie !");
                    utilisateur = "V";
                    mdpVisiteur = resultat.VIS_MDP;
                    identVisiteur = resultat.VIS_NOM;
                }
                else {
                    MessageBox.Show("Passe par le else de la boucle");
                    estValide = false;
                }
            }

            // TEST ENLEVER MAIS A REMETTRE
            /* if ((mdpVisiteur == mdpSuper) && (identVisiteur == identSuper))
             {
                 estValide = true;
                 utilisateur = "S";
                 MessageBox.Show("Secrétaire : Connexion réussie !" + estValide.ToString());
             }
             else
             {
                 // C'EST FALSE ET POURTANT CA AFFICHE LA FENETRE DE L'ACCUEIL
                 estValide = false;
                 MessageBox.Show("Passe par le else de la condition" + estValide.ToString());
             }*/

            //Delegues regionaux
            /*if ((mdp == resultat.DEL_MDP) && (ident == resultat.DEL_LOGIN))
            {
                estValide = true;
                utilisateur = "D";
                MessageBox.Show("Délégué régional : Connexion réussie !");
            }*/


            // Vérification de la correspondance
           if (estValide == true)  {
                this.Close(); // Ferme ce formulaire et ouvre l'accueil
                MessageBox.Show("Connexion réussie");
            }
            else {
                MessageBox.Show("Echec de connexion, réessayer.");

            }
        }

        // Autoriser que les lettres
        private void tb_Identifiant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Autorise SEULEMENT la saisie des lettres, pas des nombres
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
