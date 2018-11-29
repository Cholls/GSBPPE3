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
    public partial class Form_Visiteurs_Ajouter : Form
    {
        public Form_Visiteurs_Ajouter()
        {
            InitializeComponent();
        }

        private void Form_Visiteurs_Ajouter_Load(object sender, EventArgs e)
        {

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
