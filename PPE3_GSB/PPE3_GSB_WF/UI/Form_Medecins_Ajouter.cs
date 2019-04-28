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
        private string codeRegion;
        private string codeType;
        private GSB_PPE3Entities1 monModele;
        private int matriculeAlea;

        public Form_Medecins_Ajouter()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }


        private void Form_Medecins_Ajouter_Load(object sender, EventArgs e)
        {
            // Lecture du type du praticien
            // Récupère seulement le libelle
            // Selon le libelle, retrouver avec une autre requête le code de ce libelle pour l'ajouter
            // dans la création du nouveau praticien
            var req = from p in monModele.type_praticien
                      select p.TYP_LIBELLE;

            foreach(var res in req)
            {
                cb_type.Items.Add(res);
            }

            // Idem pour la région, ce comboBox affiche le libelle
            //Il faudra récupérer le code de la région pour le mettre dans la base de données
            // Récupère les régions dans la base de données
            var req1 = from v in monModele.regions
                      select v.REG_NOM;

            foreach (var resultat in req1)
            {
                cb_region.Items.Add(resultat);
            }
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
                if (tb_Nom.Text == "" && tb_Prenom.Text == "" &&
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

                   
                        try 
                        {
                            // Récupération du contenu du combobox du type du praticien
                            string selectionType = cb_type.SelectedItem.ToString();
                            // Dans le combobox du type, on récupère le libelle
                            // Il faut le code du type du praticien

                            var req1 = from p in monModele.type_praticien
                                       where p.TYP_LIBELLE == selectionType
                                       select p.TYP_CODE;
                            foreach(var res in req1)
                            {
                                codeType = res;
                            }

                            // Maintenant, il faut récupérer le code de la région à l'aide du comboBox de la région
                            string selectionRegion = cb_region.SelectedItem.ToString();

                            var req2 = from p in monModele.regions
                                       where p.REG_NOM == selectionRegion
                                       select p.REG_CODE;
                            foreach (var res in req2)
                            {
                                codeRegion = res;
                            }

                        // Tout d'abord, générer un numéro de dossier random
                        // sans que ce numéro soit déjà dans la base
                        Random aleatoire = new Random();
                        matriculeAlea = aleatoire.Next(7, 100); //Génère un entier aléatoire positif

                        // Permet de générer et d'attribuer un numéro de rapport, sans que celui-ci ne soit déjà dans la base
                        do
                        {
                            matriculeAlea = aleatoire.Next(1, 300);
                            
                        } while (monModele.praticiens.Any(a => a.PRA_NUM == matriculeAlea));
                        MessageBox.Show("Bravo, numéro de rapport généré : " + matriculeAlea + ".");
                        var unPraticien = new praticien()
                        {
                                PRA_NUM = matriculeAlea,
                                PRA_NOM = tb_Nom.Text,
                                PRA_PRENOM = tb_Prenom.Text,
                                PRA_ADRESSE = tb_Adresse.Text,
                                PRA_CP = tb_CP.Text,
                                PRA_VILLE = tb_Ville.Text,
                                PRA_COEFNOTORIETE = Convert.ToInt32(tb_coefNot.Text),
                                PRA_COEFCONFIANCE = Convert.ToInt32(tb_coefConf.Text),
                                TYP_CODE = codeType,
                                REG_CODE = codeRegion
                            };

                             // Ajout du visiteur dans la liste gérees par le programme
                             context.praticiens.Add(unPraticien);
                                // Sauvegarde de l'ajout dans la BDD
                                context.SaveChanges();
                                MessageBox.Show("Le praticien " + tb_Nom.Text + " " + tb_Prenom.Text + " à bien été ajouté", "Ajout confirmé", MessageBoxButtons.OK);

                             tb_Nom.Text = "";
                             tb_Prenom.Text = "";
                             tb_Adresse.Text = "";
                             tb_CP.Text = "";
                            tb_Ville.Text = "";
                            tb_coefNot.Text = "";
                            tb_coefConf.Text = "";

                        }
                        catch (NullReferenceException) // Si le visiteur sélectionné n'est pas dans la région sélectionnée
                        {
                            MessageBox.Show("Erreur, des champs ne sont pas renseignés, les champs sont tous obligatoires." +
                                ". ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Erreur, format de la chaine d'une saisie incorrecte, retentez.." +
                                ". ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                       
                }
            }
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

        private void tb_coefNot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
