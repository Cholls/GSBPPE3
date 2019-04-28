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
    public partial class Form_Medicament_Ajouter : Form
    {
        private string codeFamille;
        private GSB_PPE3Entities1 monModele;
        public Form_Medicament_Ajouter()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        /// <summary>
        /// S'active au chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Medicament_Ajouter_Load(object sender, EventArgs e)
        {
            // Fait afficher les données "familles des médicament"
            // Ici on fait afficher les libelles des familles. A la validation, on récupère le code 
            // correspondant au libelle à l'aide d'une requête
            var req = from m in monModele.familles
                      select m.FAM_LIBELLE;

            foreach (var resultat in req)
            {
                cb_famille.Items.Add(resultat);
            }
        }


        /// <summary>
        /// Permet d'ajouter un médicament dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Valider_Click(object sender, EventArgs e)
        {
            using (var context = new GSB_PPE3Entities1())
            {
                // Vérification si les champs sont vides. S'ils sont vides, message d'erreur.
                if (tb_Matricule.Text == "" && tb_Nom.Text == "" &&
                    tb_Compo.Text == "" && tb_contreIndic.Text == ""
                     && tb_effets.Text == "")
                {
                    MessageBox.Show("Tous les champs ne sont pas renseignés ! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // Si les champs ne sont pas vides alors, il faut les contrôler
                {
                    // Vérification si les données rentrées existent déjà
                    var req = from m in monModele.medicaments
                              select m;

                    //string num = req.First();
                    bool identique = false;
                    // Il faut parcourir la liste pour savoir si le num tapé correspond à un num dans la liste
                    foreach (var resultat in req)
                    {
                        if (tb_Matricule.Text == Convert.ToString(resultat.MED_DEPOTLEGAL))
                        {
                            identique = true;
                        }
                    }
                    // Si dans la liste, on a trouvé un numéro similaire à celui saisi dans le textbox du matricules
                    if (identique == true)
                    {
                        MessageBox.Show("Le numéro du médicament existe déjà. En choisir un autre. ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            // Récupération du contenu du combobox de la famille du médicament
                            string selectionFamille = cb_famille.SelectedItem.ToString();
                            // Dans le combobox du type, on récupère le libelle
                            // Il faut le code de la famille

                            var req1 = from p in monModele.familles
                                       where p.FAM_LIBELLE== selectionFamille
                                       select p.FAM_CODE;

                            foreach (var res in req1)
                            {
                                codeFamille = res;
                            }

                            var unMedicament = new medicament()
                            {
                                MED_DEPOTLEGAL = tb_Matricule.Text,
                                MED_NOMCOMMERCIAL = tb_Nom.Text,
                                MED_COMPOSITION = tb_Compo.Text,
                                MED_EFFETS = tb_effets.Text,
                                MED_CONTREINDIC = tb_contreIndic.Text,
                                FAM_CODE = codeFamille
                            };
                            // Ajout du médicament dans la liste gérees par le programme
                            context.medicaments.Add(unMedicament);
                            // Sauvegarde de l'ajout dans la BDD
                            context.SaveChanges();

                            MessageBox.Show("Le médicament " + tb_Nom.Text + "  à bien été ajouté", "Ajout confirmé", MessageBoxButtons.OK);
                            tb_Matricule.Text = "";
                            tb_Nom.Text = "";
                            tb_effets.Text = "";
                            tb_Compo.Text = "";
                            tb_contreIndic.Text = "";

                        }
                        catch (NullReferenceException) // Si le médicament sélectionné n'est pas dans la famille sélectionnée
                        {
                            MessageBox.Show("Erreur, des champs ne sont pas renseignés, les champs sont tous obligatoires." +
                                ". ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Erreur, format de la chaine d'une saisie incorrecte, retentez.." +
                                ". ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        /*
                        // Pour récupérer la valeur dans le comboBox
                        string selection = cb_famille.SelectedItem.ToString();
                        var unMedicament = new medicament()
                        {
                            MED_DEPOTLEGAL = tb_Matricule.Text,
                            MED_NOMCOMMERCIAL = tb_Nom.Text,
                            MED_COMPOSITION = tb_Compo.Text,
                            MED_EFFETS = tb_effets.Text,
                            MED_CONTREINDIC = tb_contreIndic.Text,
                            FAM_CODE = selection
                        };
                        // Ajout du visiteur dans la liste gérees par le programme
                        context.medicaments.Add(unMedicament);
                        // Sauvegarde de l'ajout dans la BDD
                        context.SaveChanges();

                        MessageBox.Show("Le médicament " + tb_Nom.Text + "  à bien été ajouté", "ok", MessageBoxButtons.OK);
                        tb_Matricule.Text = "";
                        tb_Nom.Text = "";
                        tb_effets = null;
                        tb_Compo = null;
                        tb_contreIndic = null;*/

                    }
                }
            }
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
