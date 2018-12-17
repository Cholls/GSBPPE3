using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PPE3_GSB_WF.Accès_aux_données;

namespace PPE3_GSB_WF
{
    public partial class Form_Medecins_Ajouter : Form
    {
        private GSB_PPE3Entities1 monModele;
        public Form_Medecins_Ajouter()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        /// <summary>
        /// Créer dans la base de données, un nouveau médecin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            using (var context = new GSB_PPE3Entities1())
            {
                // Vérification si les champs sont vides. S'ils sont vides, message d'erreur.
                if (tb_Matricule.Text == "" && tb_Nom.Text == "" && tb_Prenom.Text == "" &&
                    tb_Adresse.Text == "" && tb_CP.Text == "" && tb_Ville.Text == ""
                     && tb_coefNot.Text == "" && tb_coefConf.Text == "")
                {
                    MessageBox.Show("Tous les champs ne sont pas renseignés ! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // Si les champs ne sont pas vides alors, il faut les contrôler
                {
                    // Vérification si les données rentrées existent déjà
                    var req = from p in monModele.praticiens
                              select p;

                    //string num = req.First();
                    bool identique = false;
                    // Il faut parcourir la liste pour savoir si le num tapé correspond à un num dans la liste
                    foreach (var resultat in req)
                    {
                        if (tb_Matricule.Text == Convert.ToString(resultat.PRA_NUM))
                        {
                            identique = true;
                        }
                    }
                    // Si dans la liste, on a trouvé un numéro similaire à celui saisi dans le textbox du matricules
                    if (identique == true)
                    {
                        MessageBox.Show("Le numéro de visiteur existe déjà. En choisir un autre. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var unPraticien = new praticien()
                        {
                            PRA_NUM = Convert.ToInt32(tb_Matricule.Text),
                            PRA_NOM = tb_Nom.Text,
                            PRA_PRENOM = tb_Prenom.Text,
                            PRA_ADRESSE = tb_Adresse.Text,
                            PRA_CP = tb_CP.Text,
                            PRA_VILLE = tb_Ville.Text,
                            PRA_COEFNOTORIETE = Convert.ToInt32(tb_coefNot.Text),
                            PRA_COEFCONFIANCE = Convert.ToInt32(tb_coefConf.Text),
                            TYP_CODE = cb_spe.SelectedValue.ToString()
                        };
                        // Ajout du visiteur dans la liste gérees par le programme
                        context.praticiens.Add(unPraticien);
                        // Sauvegarde de l'ajout dans la BDD
                        context.SaveChanges();

                        MessageBox.Show("Le praticien " + tb_Nom.Text + " " + tb_Prenom.Text + " à bien été ajouté", "ok", MessageBoxButtons.OK);
                        tb_Matricule.Text = "";
                        tb_Nom.Text = "";
                        tb_Prenom.Text = "";
                        tb_Adresse.Text = "";
                        tb_CP.Text = "";
                        tb_Ville.Text = "";
                        tb_coefNot.Text = "";
                        tb_coefConf.Text = "";
                    }
                    
                }
            }
        }

        private void Form_Medecins_Ajouter_Load(object sender, EventArgs e)
        {
            // Peut-être ajouter de la lecture de données
        }
 
        /// <summary>
        /// Se déclenche quand le textbox du nom du médecin est activé
        /// Permet d'autoriser la saisie que des lettres
        /// </summary>
        private void tb_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserLettres(e);
        }

        /// <summary>
        /// Se déclenche quand le textbox du prénom du médecin est activé
        /// Permet d'autoriser la saisie que des lettres
        /// </summary>
        private void tb_Prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserLettres(e);
        }

        /// <summary>
        /// Se déclenche quand le textbox du code postal du médecin est activé
        /// Permet d'autoriser la saisie que des nombres
        /// </summary>
        private void tb_CP_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserNombre(e);
        }

        /// <summary>
        /// Se déclenche quand le textbox de la ville du médecin est activé
        /// Permet d'autoriser la saisie que des lettres
        /// </summary>
        private void tb_Ville_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserLettres(e);
        }

        /// <summary>
        /// Ce méthode sert à te faire accepter que les lettres
        /// dans la saisie de textBox
        /// </summary>
        public void AutoriserLettres(KeyPressEventArgs e)
        {
            // Autorise SEULEMENT la saisie des nombres, pas des lettres
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Ce méthode sert à te faire accepter que les nombres 
        /// dans la saisie de textBox
        /// </summary>
        public void AutoriserNombre(KeyPressEventArgs e)
        {
            // Autorise SEULEMENT la saisie des nombres, pas des lettres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                this.Close();
            }
        }

   
    }
}
