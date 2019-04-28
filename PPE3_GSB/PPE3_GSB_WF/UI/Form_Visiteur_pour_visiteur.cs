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

namespace PPE3_GSB_WF.UI
{
    public partial class Form_Visiteur_pour_visiteur : Form
    {
        private GSB_PPE3Entities1 monModele;
        public Form_Visiteur_pour_visiteur()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        // Fonction qui s'active au chargement de la page
        private void Form_Visiteur_pour_visiteur_Load(object sender, EventArgs e)
        {
            // On a besoin d'afficher les informations du visiteur médical connecté
            var req = from p in monModele.visiteurs
                      where p.VIS_NOM == labelNom.Text
                      select p;

            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                //tb_nom.Text = resultat.VIS_NOM;
                //tb_prenom.Text = resultat.VIS_PRENOM;
                tb_adresse.Text = resultat.VIS_ADRESSE;
                tb_cp.Text = resultat.VIS_CP;
                tb_ville.Text = resultat.VIS_VILLE;
                tb_dateEmbauche.Text = Convert.ToString(resultat.VIS_DATEEMBAUCHE);
            }
        }

        // Fonction servant simplement à fermer l'application
        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fonction qui sert à activer tous les champs du visiteur médical afin de permettre la modification
            tb_adresse.ReadOnly = false;
            tb_cp.ReadOnly = false;
            tb_dateEmbauche.ReadOnly = false;
            tb_ville.ReadOnly = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Permet de valider les modifications
            // Récupération du contenu du combobox 
            string selection = labelNom.Text;
            var vis = from p in monModele.visiteurs
                      where p.VIS_NOM == selection
                      select p;

            // Remplissage des modifications sur chaque champ de la table de la base de données
            foreach (var resultat in vis)
            {
                resultat.VIS_ADRESSE = tb_adresse.Text;
                resultat.VIS_CP = tb_cp.Text;
                resultat.VIS_VILLE = tb_ville.Text;
                //resultat.VIS_DATEEMBAUCHE = Convert.ToDateTime(tb_dateEmbauche);
            }
            // Faire une vérif si une modification a lieu 
            MessageBox.Show("Les données ont bien été modifiées !");
            monModele.SaveChanges();

            tb_adresse.ReadOnly = true;
            tb_cp.ReadOnly = true;
            tb_dateEmbauche.ReadOnly = true;
            tb_ville.ReadOnly = true;
        }
    }
}
