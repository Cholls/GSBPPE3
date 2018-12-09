﻿using System;
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
    public partial class Form_Medecins_Ajouter : Form
    {
        public Form_Medecins_Ajouter()
        {
            InitializeComponent();

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
                if (tb_Matricule.Text == "" && tb_Nom.Text == "" && tb_Prenom.Text == "" &&
                    tb_Adresse.Text == "" && tb_CP.Text == "" && tb_Ville.Text == ""
                     && tb_coefNot.Text == "" && tb_coefConf.Text == "")
                {
                    MessageBox.Show("Tous les champs ne sont pas renseignés ! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        TYP_CODE = cb_spe.Text
                    };
                    // Ajout du visiteur dans la liste gérees par le programme
                    context.praticiens.Add(unPraticien);
                    // Sauvegarde de l'ajout dans la BDD
                    context.SaveChanges();
                }
            }
        }

        private void Form_Medecins_Ajouter_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet3.specialite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialiteTableAdapter.Fill(this.gSB_PPE3DataSet3.specialite);

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
