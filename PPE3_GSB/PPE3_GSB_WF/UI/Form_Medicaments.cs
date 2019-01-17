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
    public partial class Form_Medicaments : Form
    {
        private GSB_PPE3Entities1 monModele;
        private string recupFamille;
        public Form_Medicaments()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
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
        /// Actions définies au chargement du formulaire des médicaments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Medicaments_Load(object sender, EventArgs e)
        {
            RechargerDonneescb();
        }

        private void bt_valid_Click(object sender, EventArgs e)
        {

            // Bouton cliqué, donc on peut activer les champs
            // correspondant aux différents attributs
            btn_suppr.Enabled = true;
            tb_nom.ReadOnly = false;
            tb_compo.ReadOnly = false;
            tb_contre.ReadOnly = false;
            tb_effet.ReadOnly = false;
            //tb_famille.ReadOnly = false;

            // Détecte si aucune entrée dans les combobox est sélectionnée
            if (cb_select.Text == "")
            {
                MessageBox.Show("Aucune sélection, attention !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try // Faire un bloc try catch au cas où une erreur pourrait survenir 
                    // quand un médicament n'est pas dans la famille sélectionnée
                {
                    // Pour récupérer la valeur dans le comboBox
                    string selection = cb_select.SelectedItem.ToString();
                    var req = from p in monModele.medicaments
                              where p.MED_NOMCOMMERCIAL == selection
                              select p;
                    // Tout afficher dans les TextBox
                    foreach (var resultat in req)
                    {
                        tb_nom.Text = resultat.MED_NOMCOMMERCIAL;
                        tb_compo.Text = resultat.MED_COMPOSITION;
                        tb_effet.Text = resultat.MED_EFFETS;
                        tb_contre.Text = resultat.MED_CONTREINDIC;
                        tb_famille.Text = resultat.FAM_CODE;
                    }
                }
                catch (NullReferenceException)   // Si exception levée
                {
                    MessageBox.Show("Erreur, ce médicament n'est pas dans cette famille. Veuillez sélectionner un médicament " +
                        "dans la famille sélectionnée. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cb_select.Items.Clear();
                }
            }
        }

        /// <summary>
        /// Ouvre la fenêtre d'ajout de médicaments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            Form_Medicament_Ajouter fa = new Form_Medicament_Ajouter();
            fa.Show();
        }
        /// <summary>
        /// Permet de charger les noms des médicaments dans la secondes combobox
        /// </summary>
        /// <remarks> Se déclenche quand une famille de médicaments est sélectionnée</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_famille_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nettoie ce qui est déjà dans la comboBox
            // Si une recherche a déjà été faite
            cb_select.Items.Clear();

            // Récupère la sélection du premier comboBox (de la région)
            string selection = cb_famille.SelectedItem.ToString();

            // Requête pour récupérer le code de des familles
            // de la région sélectionnée dans le premier combobox
            var recupCode = from p in monModele.familles
                            where p.FAM_LIBELLE == selection
                            select p.FAM_CODE;

            // Récupération du code de la famille
            foreach (var resultat in recupCode)
            {
                recupFamille = resultat;
            }

            // Récupération des visiteurs étant dans la région sélectionnée dans le comboBox
            var med = from p in monModele.medicaments
                      where p.FAM_CODE == recupFamille
                      select p.MED_NOMCOMMERCIAL;

            foreach (var resultat in med)
            {
                cb_select.Items.Add(resultat);
            }
        }

        //Permet de supprimer le médicament sélectionné dans le deuxième combobox
        private void btn_suppr_Click(object sender, EventArgs e)
        {
            string selection = tb_nom.Text;
            if (cb_select.Text == "")
            {
                MessageBox.Show("Erreur, champ vide, suppression impossible. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce médicament ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                {
                    var deletemed = from med in monModele.medicaments
                                    where med.MED_NOMCOMMERCIAL == selection
                                    select med;


                    foreach (var med in deletemed)
                    {
                        MessageBox.Show("Le médicament " + med.MED_NOMCOMMERCIAL + " a bien été supprimé.");
                        var deleteConstituer = from p in monModele.constituers
                                               where p.MED_DEPOTLEGAL == med.MED_DEPOTLEGAL
                                               select p;

                        foreach (var p in deleteConstituer)
                        {
                            MessageBox.Show("Le médicament " + med.MED_NOMCOMMERCIAL +  " a bien été supprimé.");
                            monModele.constituers.Remove(p);
                            monModele.medicaments.Remove(med);
                        }

                    }
                    monModele.SaveChanges();
                    tb_compo.Text = "";
                    tb_contre.Text = "";
                    tb_effet.Text = "";
                    tb_famille.Text = "";
                    tb_nom.Text = "";
                    cb_select.Items.Clear();
                    RechargerDonneescb(); // Recharge les données de la comboBox des médicaments

                }
            }
        }

        // Permet de charger ou de recharger les données dans le combobox
        // affichant la liste des médicaments
        private void RechargerDonneescb()
        {
            //Affiche les familles des médicaments
            var req = from m in monModele.familles
                      select m.FAM_LIBELLE;

            foreach (var resultat in req)
            {
                cb_famille.Items.Add(resultat);
            }
        }
    }
}
