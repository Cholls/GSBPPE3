namespace PPE3_GSB_WF
{
    partial class Form_Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnu_Accueil = new System.Windows.Forms.MenuStrip();
            this.mnu_Visiteurs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rapports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Medicaments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Medecins = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Accueil
            // 
            this.mnu_Accueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Visiteurs,
            this.mnu_Rapports,
            this.mnu_Medicaments,
            this.mnu_Medecins});
            this.mnu_Accueil.Location = new System.Drawing.Point(0, 0);
            this.mnu_Accueil.Name = "mnu_Accueil";
            this.mnu_Accueil.Size = new System.Drawing.Size(784, 24);
            this.mnu_Accueil.TabIndex = 1;
            this.mnu_Accueil.Text = "menuStrip1";
            // 
            // mnu_Visiteurs
            // 
            this.mnu_Visiteurs.Name = "mnu_Visiteurs";
            this.mnu_Visiteurs.Size = new System.Drawing.Size(63, 20);
            this.mnu_Visiteurs.Text = "Visiteurs";
            this.mnu_Visiteurs.Click += new System.EventHandler(this.visiteursToolStripMenuItem_Click);
            // 
            // mnu_Rapports
            // 
            this.mnu_Rapports.Name = "mnu_Rapports";
            this.mnu_Rapports.Size = new System.Drawing.Size(66, 20);
            this.mnu_Rapports.Text = "Rapports";
            this.mnu_Rapports.Click += new System.EventHandler(this.rapportsToolStripMenuItem_Click);
            // 
            // mnu_Medicaments
            // 
            this.mnu_Medicaments.Name = "mnu_Medicaments";
            this.mnu_Medicaments.Size = new System.Drawing.Size(91, 20);
            this.mnu_Medicaments.Text = "Medicaments";
            this.mnu_Medicaments.Click += new System.EventHandler(this.medicamentsToolStripMenuItem_Click);
            // 
            // mnu_Medecins
            // 
            this.mnu_Medecins.Name = "mnu_Medecins";
            this.mnu_Medecins.Size = new System.Drawing.Size(70, 20);
            this.mnu_Medecins.Text = "Medecins";
            this.mnu_Medecins.Click += new System.EventHandler(this.medecinsToolStripMenuItem_Click);
            // 
            // Form_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_GSB_WF.Properties.Resources.logogsb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.mnu_Accueil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form_Accueil_Load);
            this.mnu_Accueil.ResumeLayout(false);
            this.mnu_Accueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_Accueil;
        private System.Windows.Forms.ToolStripMenuItem mnu_Visiteurs;
        private System.Windows.Forms.ToolStripMenuItem mnu_Rapports;
        private System.Windows.Forms.ToolStripMenuItem mnu_Medicaments;
        private System.Windows.Forms.ToolStripMenuItem mnu_Medecins;
    }
}