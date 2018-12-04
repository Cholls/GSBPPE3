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

        }

        private void Form_Medecins_Ajouter_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_PPE3DataSet3.specialite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialiteTableAdapter.Fill(this.gSB_PPE3DataSet3.specialite);

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
