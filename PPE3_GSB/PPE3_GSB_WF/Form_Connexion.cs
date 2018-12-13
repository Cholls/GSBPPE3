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
    public partial class Form_Connexion : Form
    {
        string identSuper = "gsbadmin";
        string mdpSuper = "mdp";

        private GSB_PPE3Entities1 monModele;
        public Form_Connexion()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer l'application ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
                this.getIdent();
                this.getMdp();
            }
            
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            // Ici, vérifier qui se connecte :
            // Si c'est un visiteur, n'afficher que l'onglet des rapports
            // Si c'est un délegué régional, il voit les rapports et les visiteurs de sa région
            // Si c'est une personne chargée de la gestion, elle peut tout voir
            // ATTENTION POUR L'INSTANT, SEULE LA CONNEXION DES VISITEURS EST GEREES PARTIELLEMENT
            // (Actuellement, le visiteur a accès à tout)
         
            // Voir pour crypter les mdp dans le futur proche
            string mdp = tb_MotDePasse.Text;
            string ident = tb_Identifiant.Text;
                
            //TEST CONNEXION DES VISITEURS
            //Parcourir la liste des logins et des mot de passes des visiteurs
            var req1 = from v in monModele.visiteurs
                       where v.VIS_LOGIN == ident 
                       && v.VIS_MDP == mdp
                      select v;


            // TEST CONNEXION SECRETAIRE (Super utilisateur)
 
            bool estValide = false;
            foreach (var resultat in req1)
            {
                // Vérification de la correspondance
                // Voir comment faire pour réussir l'autentification
                if ((mdp == resultat.VIS_MDP) && (ident == resultat.VIS_LOGIN)) {
                    estValide = true;

                } // NE FONCTIONNE PAS
                else if (mdp == mdpSuper && ident == identSuper) {
                    estValide = true;
                    
                }else
                    estValide = false;
            }

            // Vérification de la correspondance
            if (estValide == true)  {
                MessageBox.Show("Connexion réussie !");
                this.Close();
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

        public string getIdent()
        {
            return tb_Identifiant.Text;
        }

        public string getMdp()
        {
            return tb_MotDePasse.Text;
        }

    }
}
