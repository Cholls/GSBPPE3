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
            }
            
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            // Ici, vérifier qui se connecte :
            // Si c'est un visiteur, n'afficher que l'onglet des rapports
            // Si c'est un délegué régional, il voit les rapports et les visiteurs de sa région
            // Si c'est une personne chargée de la gestion, elle peut tout voir
            // Commençons d'abord par les visiteurs

            //Parcourir la liste des logins et des mot de passes des visiteurs
            var req = from v in monModele.visiteurs
                      select v;

            bool estValide = true;
            foreach (var resultat in req)
            {
                // Vérification de la correspondance
                // Voir comment faire pour réussir l'autentification
                if(tb_Identifiant.Text == resultat.VIS_LOGIN &&
                    tb_MotDePasse.Text == resultat.VIS_MDP)
                {
                    estValide = true;
                }
                else
                {
                    estValide = false;
                }
            }

            // Vérification de la correspondance
            if (estValide == true)
            {
                MessageBox.Show("Connexion réussie !");
                this.Close();
            }
            else
            {
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

        // Autorise que les nombres
        private void tb_MotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Autorise SEULEMENT la saisie des nombres, pas des lettres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
