﻿using System;
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
    public partial class Form_Visiteurs_Ajouter : Form
    {
        private GSB_PPE3Entities1 monModele;
        private string codeRegion;

        public Form_Visiteurs_Ajouter()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();

        }

        private void Form_Visiteurs_Ajouter_Load(object sender, EventArgs e)
        {
            // Les régions doivent être chargés pour être affichées
            RechargerDonneescb();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Permet d'ajouter un visiteur avec les informations récupérées
        /// dans les Textbox remplies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            using (var context = new GSB_PPE3Entities1())
            {
                if (tb_Matricule.Text == "" && tb_Nom.Text == "" && tb_Prenom.Text == "" &&
                tb_Adresse.Text == "" && tb_CP.Text == "" && tb_Ville.Text == ""
                && dtp_DateEmbauche.Text == "" && tb_Login.Text == "" && tb_MotDePasse.Text == "")
                {
                    MessageBox.Show("Tous les champs ne sont pas renseignés ! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // Si les champs ne sont pas vides alors, il faut les contrôler
                {
                    // Vérification si les données rentrées existent déjà
                    var req = from v in monModele.visiteurs
                              select v;

                    //string num = req.First();
                    bool identique = false;
                    // Il faut parcourir la liste pour savoir si le num tapé correspond à un num dans la liste
                    foreach (var resultat in req)
                    {
                        if (tb_Matricule.Text == resultat.VIS_MATRICULE)
                        {
                            identique = true;
                        }
                    }
                    // Si dans la liste, on a trouvé un numéro similaire à celui saisi dans le textbox du matricule
                    if (identique == true)
                    {
                        MessageBox.Show("Le numéro de visiteur existe déjà. En choisir un autre. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            // Maintenant, il faut récupérer le code de la région à l'aide du comboBox de la région
                            string selectionRegion = cb_region.SelectedItem.ToString();

                            var req2 = from p in monModele.regions
                                       where p.REG_NOM == selectionRegion
                                       select p.REG_CODE;
                            foreach (var res in req2)
                            {
                                codeRegion = res;
                            }

                            // Déclaration d'un nouveau visiteur
                            var unVisiteur = new visiteur()
                            {

                                VIS_MATRICULE = tb_Matricule.Text,
                                VIS_NOM = tb_Nom.Text,
                                VIS_PRENOM = tb_Prenom.Text,
                                VIS_ADRESSE = tb_Adresse.Text,
                                VIS_CP = tb_CP.Text,
                                VIS_VILLE = tb_Ville.Text,
                                VIS_DATEEMBAUCHE = Convert.ToDateTime(dtp_DateEmbauche.Text),
                                VIS_LOGIN = tb_Login.Text,
                                VIS_MDP = tb_MotDePasse.Text
                            };

                            // Ajout du visiteur dans la liste gérees par le programme
                            context.visiteurs.Add(unVisiteur);
                            // Sauvegarde de l'ajout dans la BDD
                            context.SaveChanges();
                            MessageBox.Show("Le visiteur " + tb_Nom.Text + " " + tb_Prenom.Text + " à bien été ajouté", "ok", MessageBoxButtons.OK);
                            tb_Matricule.Text = "";
                            tb_Nom.Text = "";
                            tb_Prenom.Text = "";
                            tb_Adresse.Text = "";
                            tb_CP.Text = "";
                            tb_Ville.Text = "";
                            dtp_DateEmbauche.Text = "";
                            tb_Login.Text = "";
                            tb_MotDePasse.Text = "";
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
        }

        // TOUS LES TESTS DE SAISIES SE TROUVENT ICI
        // ------------------------------------------------------
        /// <summary>
        /// Se déclenche quand le textBox Code postal de visiteur
        /// est activé
        /// Permet de faire écrire que des nombres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_CP_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserNombre(e);
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

        /// <summary>
        /// Cette méthode sert à te faire accepter que les lettres
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
        /// Se déclenche quand le textbox du nom du visiteur est activé
        /// Permet d'autoriser la saisie que des lettres
        /// </summary>
        private void tb_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserLettres(e);
        }

        /// <summary>
        /// Se déclenche quand le textbox du prénom du visiteur est activé
        /// Permet d'autoriser la saisie que des lettres
        /// </summary>
        private void tb_Prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserLettres(e);
        }

        /// <summary>
        /// Se déclenche quand le textbox de la ville du visiteur est activé
        /// Permet d'autoriser la saisie que des lettres
        /// </summary>
        private void tb_Ville_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserLettres(e);
        }

        private void tb_DateEmbauche_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserNombre(e);
        }

        private void RechargerDonneescb()
        {
            // Récupère les régions dans la base de données
            var req = from v in monModele.regions
                      select v;

            foreach (var resultat in req)
            {
                cb_region.Items.Add(resultat.REG_NOM);
            }
        }
    }

}
