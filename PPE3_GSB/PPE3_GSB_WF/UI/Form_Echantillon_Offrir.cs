using PPE3_GSB_WF.Accès_aux_données;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_GSB_WF.UI
{
    public partial class Form_Echantillon_Offrir : Form
    {
        private GSB_PPE3Entities1 monModele;
        public Form_Echantillon_Offrir()
        {
            InitializeComponent();
            monModele = new GSB_PPE3Entities1();
        }

        public string Input
        {
            get { return cb_select.Text; }
        }

        public string Input2
        {
            get { return tb_qt.Text; }
        }
        private void bt_valid_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Echantillon_Offrir_Load(object sender, EventArgs e)
        {
            //Affiche la liste des médicaments
            var req = from m in monModele.medicaments
                      select m.MED_NOMCOMMERCIAL;

            foreach (var resultat in req)
            {
                cb_select.Items.Add(resultat);
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


        private void tb_qt_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoriserNombre(e);
        }
    }
}
