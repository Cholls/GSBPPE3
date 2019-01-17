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
    public partial class Form_Visiteurs : Form
    {
        private GSB_PPE3Entities1 monModele;
        private string recupRegCode;
        public Form_Visiteurs()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        /// <summary>
        /// Se produit au chargement du formulaire des visiteurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Visiteurs_Load(object sender, EventArgs e)
        {
            RechargerCompteur();
            RechargerDonneescb();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous fermer la fenêtre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Visiteurs_Ajouter fva = new Form_Visiteurs_Ajouter();
            fva.Show();
        }


        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Form_Visiteurs_Modifier fvm = new Form_Visiteurs_Modifier();
            fvm.Show();
        }


        /// <summary>
        /// Pour afficher les informations d'un visiteur sélectionné
        /// dans un comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Bouton cliqué, donc on peut activer les champs 
            // correspondant aux différents attributs
            btn_suppr.Enabled = true;
            tb_nom.ReadOnly = false;
            tb_prenom.ReadOnly = false;
            tb_cp.ReadOnly = false;
            tb_ville.ReadOnly = false;
            tb_adresse.ReadOnly = false;
            tb_dateEmbauche.ReadOnly = false;

            // Détecte si aucune entrée dans les combobox est sélectionnée
            if(cb_select.Text == "")
            {
                MessageBox.Show("Aucune sélection, attention !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try // Faire un bloc try catch au cas où une erreur pourrait survenir 
                    // quand un visiteur n'est pas dans la région sélectionnée
                {
                    // Récupération du contenu du combobox 
                    string selection = cb_select.SelectedItem.ToString();

                    // Récupère les données du visiteur sélectionné dans la combobox
                    var req = from p in monModele.visiteurs
                              where p.VIS_NOM == selection
                              select p;

                    // Tout afficher dans les TextBox
                    foreach (var resultat in req)
                    {
                        tb_nom.Text = resultat.VIS_NOM;
                        tb_prenom.Text = resultat.VIS_PRENOM;
                        tb_adresse.Text = resultat.VIS_ADRESSE;
                        tb_cp.Text = resultat.VIS_CP;
                        tb_ville.Text = resultat.VIS_VILLE;
                        tb_dateEmbauche.Text = Convert.ToString(resultat.VIS_DATEEMBAUCHE);
                    }
                    MessageBox.Show("Chargement d'un visiteur sélectionné : " + cb_select.Text);
                }catch(NullReferenceException) // Si le visiteur sélectionné n'est pas dans la région sélectionnée
                {
                    MessageBox.Show("Erreur, ce visiteur n'est pas dans cette région. Veuillez sélectionner un visiteur " +
                        "dans la région sélectionnée. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cb_select.Items.Clear();
                } 
            }
        }

        /// <summary>
        /// Permet de prendre en compte les modifications faites
        /// aux différents champs du visiteur sélectionné par 
        /// la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Récupération du contenu du combobox 
            string selection = cb_select.SelectedItem.ToString();
            var vis = from p in monModele.visiteurs
                      where p.VIS_NOM == selection
                      select p;

            // Remplissage des modifications sur chaque champ de la table de la base de données
            foreach (var resultat in vis)
            {
                resultat.VIS_NOM = tb_nom.Text;
                resultat.VIS_NOM = tb_nom.Text;
                resultat.VIS_PRENOM = tb_prenom.Text;
                resultat.VIS_ADRESSE = tb_adresse.Text;
                resultat.VIS_CP = tb_cp.Text;
                resultat.VIS_VILLE = tb_ville.Text;
                //resultat.VIS_DATEEMBAUCHE = Convert.ToDateTime(tb_dateEmbauche);
            }
            // Faire une vérif si une modification a lieu 
            MessageBox.Show("Les données ont bien été modifiées !");
            monModele.SaveChanges();
        }

        /// <summary>
        /// Permet de charger les visiteurs dans la seconde combobox
        /// correspondant à la région sélectionnée
        /// </summary>
        /// <remarks>
        /// Se déclenche quand la valeur du premier comboBox est sélectionnée </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nettoie ce qui est déjà dans la comboBox
            // Si une recherche a déjà été faite
            cb_select.Items.Clear();

            // Récupère la sélection du premier comboBox (de la région)
            string selection = cb_region.SelectedItem.ToString();

            // Requête pour récupérer le code de la région
            // de la région sélectionnée dans le premier combobox
            var recupCode = from p in monModele.regions
                            where p.REG_NOM == selection
                            select p.REG_CODE;

            // Récupération du code de la région
            foreach (var resultat in recupCode)
            {
                recupRegCode = resultat;
            }

        // Récupération des visiteurs étant dans la région sélectionnée dans le comboBox
            var vis = from p in monModele.visiteurs
                      where p.REG_CODE == recupRegCode
                      select p.VIS_NOM;

            foreach (var resultat in vis)
            {
                    cb_select.Items.Add(resultat);
            } 
        }

        private void cb_region_MouseClick(object sender, MouseEventArgs e)
        {
            cb_select.Items.Clear();
        }

        // Permet de supprimer un visiteur
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
                    var deletevis = from vis in monModele.visiteurs
                                     where vis.VIS_NOM == selection
                                     select vis;

                    foreach (var vis in deletevis)
                    {
                        MessageBox.Show("Le praticien " + vis.VIS_NOM  + " a bien été supprimé.");
                        monModele.visiteurs.Remove(vis);
                        
                    }
                    monModele.SaveChanges();

                    tb_adresse.Text = "";
                    tb_cp.Text = "";
                    tb_nom.Text = "";
                    tb_prenom.Text = "";
                    tb_adresse.Text = "";
                    tb_ville.Text = "";
                    tb_dateEmbauche.Text = "";
                    cb_select.Items.Clear();
                    RechargerDonneescb(); // Recharge les données de la comboBox des praticiens
                    RechargerCompteur(); // Recompte le nombres des praticiens
                }
            }
        }

        private void RechargerCompteur()
        {
            // Faire le compteur des visiteurs
            var reqNbVisiteur = from v in monModele.visiteurs
                                select v;
            int nbVisiteur = reqNbVisiteur.Count();
            tx_visiteur.Text = Convert.ToString(nbVisiteur);
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
