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
    public partial class Form_Visiteurs_Ajouter : Form
    {
        public Form_Visiteurs_Ajouter()
        {
            InitializeComponent();
        }

        private void Form_Visiteurs_Ajouter_Load(object sender, EventArgs e)
        {

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permet d'ajouter un visiteur avec les informations récupérées
        /// dans les Textbox remplies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
          /*using (var context = new GSB_PPE3Entities()) // UNE ERREUR ICI 
            {
                // Déclaration d'un nouveau visiteur
                var unVisiteur = new visiteur()
                {
                    VIS_MATRICULE = tb_Matricule.Text,
                    VIS_NOM = tb_Nom.Text,
                    VIS_PRENOM = tb_Prenom.Text,
                    VIS_ADRESSE = tb_Adresse.Text,
                    VIS_CP = tb_CP.Text,
                    VIS_VILLE = tb_Ville.Text,
                    VIS_DATEEMBAUCHE = Convert.ToDateTime(tb_DateEmbauche.Text),
                    VIS_LOGIN = tb_Login.Text,
                    VIS_MDP = tb_MotDePasse.Text
                };

                // Ajout du visiteur dans la liste gérees par le programme
                context.visiteurs.Add(unVisiteur);
                // Sauvegarde de l'ajout dans la BDD
                context.SaveChanges();
            } */
        }
    }
}
