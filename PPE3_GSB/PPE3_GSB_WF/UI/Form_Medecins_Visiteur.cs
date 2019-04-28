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
using PPE3_GSB_WF.UI;


namespace PPE3_GSB_WF.UI

/// <summary>
/// Ce formulaire est visible uniquement par les visiteurs
/// Permet de visualiser tous les praticiens présents dans la zone géographique
/// du visiteur connecté
/// </summary>
/// 

{
    public partial class Form_Medecins_Visiteur : Form
    {
        private GSB_PPE3Entities1 monModele;
        private string regionVisiteur;

        public Form_Medecins_Visiteur()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        /// <summary>
        /// Défini les actions faites au chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Medecins_Visiteur_Load(object sender, EventArgs e)
        {
            // Recherche de la région du visiteur connecté
            var req = from p in monModele.visiteurs
                      where p.VIS_NOM == labelNom.Text
                      select p.REG_CODE;

            foreach(var resultat in req)
            {
                regionVisiteur = resultat;
            }

            // Faire en sorte de n'afficher que les praticiens uniquement dans 
            // le même département que le visiteur 
            var req1 = from p in monModele.praticiens
                       where p.REG_CODE == regionVisiteur
                       select p;

            
            // Ajout des médecins dans le comboBox correspondant au cp du visiteur
            foreach(var resultat in req1)
            {
                cb_select.Items.Add(resultat.PRA_NOM);
            }

        }

        /// <summary>
        /// Permet d'ouvrir le formulaire de création d'un nouveau praticien
        /// au click de ce bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Medecins_Ajouter fva = new Form_Medecins_Ajouter();
            fva.Show();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Permet d'enregistrer les modifications faites dans les textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Se déclenche quand le bouton de validation
        /// du cb_select est appuyé
        /// permet d'afficher les informations du praticiens sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valid_selection_Click(object sender, EventArgs e)
        {
            // Bouton cliqué, donc on peut activer les champs 
            // correspondant aux différents attributs
            tb_nom.ReadOnly = false;
            tb_prenom.ReadOnly = false;
            tb_cp.ReadOnly = false;
            tb_ville.ReadOnly = false;
            tb_adresse.ReadOnly = false;
            tb_coefConf.ReadOnly = false;
            tb_coefNot.ReadOnly = false;
            tb_coefNot.ReadOnly = false;
            tb_type.ReadOnly = false;

            // Récupération du contenu du combobox 
            string selection = cb_select.SelectedItem.ToString();

            var req = from p in monModele.praticiens
                      where p.PRA_NOM == selection
                      select p;

            // Tout afficher dans les TextBox
            foreach (var resultat in req)
            {
                tb_nom.Text = resultat.PRA_NOM;
                tb_prenom.Text = resultat.PRA_PRENOM;
                tb_adresse.Text = resultat.PRA_ADRESSE;
                tb_cp.Text = resultat.PRA_CP;
                tb_ville.Text = resultat.PRA_VILLE;
                tb_coefNot.Text = Convert.ToString(resultat.PRA_COEFNOTORIETE);
                tb_coefConf.Text = Convert.ToString(resultat.PRA_COEFCONFIANCE);
                tb_type.Text = resultat.TYP_CODE;
            }
        }

        /// <summary>
        /// Permet de supprimer le visiteur concerné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_suppr_Click(object sender, EventArgs e)
        {
            string selection = tb_nom.Text;
            if (cb_select.Text == "")
            {
                MessageBox.Show("Erreur, champ vide, suppression impossible. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce praticien ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                {
                    var deleteprat = from prat in monModele.praticiens
                                     where prat.PRA_NOM == selection
                                     select prat;

                    foreach (var prat in deleteprat)
                    {
                        var deletePossession = from p in monModele.posseders
                                               where p.PRA_NUM == prat.PRA_NUM
                                               select p;
                        foreach (var p in deletePossession)
                        {
                            MessageBox.Show("Le praticien " + prat.PRA_NOM + " a bien été supprimé.");
                            monModele.posseders.Remove(p);
                            monModele.praticiens.Remove(prat);
                        }
                    }
                    monModele.SaveChanges();
                    tb_type.Text = "";
                    tb_coefConf.Text = "";
                    tb_cp.Text = "";
                    tb_nom.Text = "";
                    tb_prenom.Text = "";
                    tb_adresse.Text = "";
                    tb_ville.Text = "";
                    tb_coefNot.Text = "";
                    cb_select.Items.Clear();
                    //RechargerDonneescb(); // Recharge les données de la comboBox des praticiens
                    RechargerCompteur(); // Recompte le nombres des praticiens
                }
            }
        }

        private void RechargerCompteur()
        {
            // Faire le compteur des praticiens
            var reqNbVisiteur = from v in monModele.praticiens
                                select v;
            int nbPraticien = reqNbVisiteur.Count();
            txt_nb_praticien.Text = Convert.ToString(nbPraticien);
        }
    
    }
}
