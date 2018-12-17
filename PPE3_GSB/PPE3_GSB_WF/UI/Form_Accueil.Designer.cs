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
            this.ajouterUnVisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rapports = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualSecretaria = new System.Windows.Forms.ToolStripMenuItem();
            this.visualVisiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Medicaments = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Medecins = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMédecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesMedecintoolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.mnu_Accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Accueil
            // 
            this.mnu_Accueil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_Accueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Visiteurs,
            this.mnu_Rapports,
            this.mnu_Medicaments,
            this.mnu_Medecins,
            this.seDéconnecterToolStripMenuItem});
            this.mnu_Accueil.Location = new System.Drawing.Point(0, 0);
            this.mnu_Accueil.Name = "mnu_Accueil";
            this.mnu_Accueil.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnu_Accueil.Size = new System.Drawing.Size(1045, 28);
            this.mnu_Accueil.TabIndex = 1;
            this.mnu_Accueil.Text = "menuStrip1";
            // 
            // mnu_Visiteurs
            // 
            this.mnu_Visiteurs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnVisiteurToolStripMenuItem,
            this.visualiserLesVisiteursToolStripMenuItem});
            this.mnu_Visiteurs.Name = "mnu_Visiteurs";
            this.mnu_Visiteurs.Size = new System.Drawing.Size(76, 24);
            this.mnu_Visiteurs.Text = "Visiteurs";
            // 
            // ajouterUnVisiteurToolStripMenuItem
            // 
            this.ajouterUnVisiteurToolStripMenuItem.Name = "ajouterUnVisiteurToolStripMenuItem";
            this.ajouterUnVisiteurToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.ajouterUnVisiteurToolStripMenuItem.Text = "Ajouter un visiteur";
            this.ajouterUnVisiteurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnVisiteurToolStripMenuItem_Click);
            // 
            // visualiserLesVisiteursToolStripMenuItem
            // 
            this.visualiserLesVisiteursToolStripMenuItem.Name = "visualiserLesVisiteursToolStripMenuItem";
            this.visualiserLesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.visualiserLesVisiteursToolStripMenuItem.Text = "Visualiser les visiteurs";
            this.visualiserLesVisiteursToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesVisiteursToolStripMenuItem_Click);
            // 
            // mnu_Rapports
            // 
            this.mnu_Rapports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnRapportToolStripMenuItem,
            this.visualSecretaria,
            this.visualVisiteur});
            this.mnu_Rapports.Name = "mnu_Rapports";
            this.mnu_Rapports.Size = new System.Drawing.Size(81, 24);
            this.mnu_Rapports.Text = "Rapports";
            // 
            // ajouterUnRapportToolStripMenuItem
            // 
            this.ajouterUnRapportToolStripMenuItem.Name = "ajouterUnRapportToolStripMenuItem";
            this.ajouterUnRapportToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.ajouterUnRapportToolStripMenuItem.Text = "Ajouter un rapport";
            this.ajouterUnRapportToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnRapportToolStripMenuItem_Click);
            // 
            // visualSecretaria
            // 
            this.visualSecretaria.Name = "visualSecretaria";
            this.visualSecretaria.Size = new System.Drawing.Size(291, 26);
            this.visualSecretaria.Text = "Visualiser les rapports";
            this.visualSecretaria.Click += new System.EventHandler(this.visualiserLesRapportsToolStripMenuItem_Click);
            // 
            // visualVisiteur
            // 
            this.visualVisiteur.Name = "visualVisiteur";
            this.visualVisiteur.Size = new System.Drawing.Size(291, 26);
            this.visualVisiteur.Text = "Visiteur - Visualiser les rapports";
            this.visualVisiteur.Click += new System.EventHandler(this.visualVisiteur_Click);
            // 
            // mnu_Medicaments
            // 
            this.mnu_Medicaments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnMédicamentToolStripMenuItem,
            this.visualiserLesMédicamentsToolStripMenuItem});
            this.mnu_Medicaments.Name = "mnu_Medicaments";
            this.mnu_Medicaments.Size = new System.Drawing.Size(110, 24);
            this.mnu_Medicaments.Text = "Medicaments";
            // 
            // ajouterUnMédicamentToolStripMenuItem
            // 
            this.ajouterUnMédicamentToolStripMenuItem.Name = "ajouterUnMédicamentToolStripMenuItem";
            this.ajouterUnMédicamentToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.ajouterUnMédicamentToolStripMenuItem.Text = "Ajouter un médicament";
            this.ajouterUnMédicamentToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMédicamentToolStripMenuItem_Click);
            // 
            // visualiserLesMédicamentsToolStripMenuItem
            // 
            this.visualiserLesMédicamentsToolStripMenuItem.Name = "visualiserLesMédicamentsToolStripMenuItem";
            this.visualiserLesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.visualiserLesMédicamentsToolStripMenuItem.Text = "Visualiser les médicaments";
            this.visualiserLesMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesMédicamentsToolStripMenuItem_Click);
            // 
            // mnu_Medecins
            // 
            this.mnu_Medecins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnMédecinToolStripMenuItem,
            this.visualiserLesMedecintoolTip});
            this.mnu_Medecins.Name = "mnu_Medecins";
            this.mnu_Medecins.Size = new System.Drawing.Size(84, 24);
            this.mnu_Medecins.Text = "Medecins";
            // 
            // ajouterUnMédecinToolStripMenuItem
            // 
            this.ajouterUnMédecinToolStripMenuItem.Name = "ajouterUnMédecinToolStripMenuItem";
            this.ajouterUnMédecinToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.ajouterUnMédecinToolStripMenuItem.Text = "Ajouter un médecin";
            this.ajouterUnMédecinToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMédecinToolStripMenuItem_Click);
            // 
            // visualiserLesMedecintoolTip
            // 
            this.visualiserLesMedecintoolTip.Name = "visualiserLesMedecintoolTip";
            this.visualiserLesMedecintoolTip.Size = new System.Drawing.Size(235, 26);
            this.visualiserLesMedecintoolTip.Text = "Visualiser les médecins";
            this.visualiserLesMedecintoolTip.Click += new System.EventHandler(this.visualiserLesMedecintoolTip_Click);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenue, ";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(704, 4);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(51, 24);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(847, 4);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(82, 24);
            this.labelPrenom.TabIndex = 5;
            this.labelPrenom.Text = "prénom";
            // 
            // Form_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE3_GSB_WF.Properties.Resources.logogsb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnu_Accueil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB ";
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
        private System.Windows.Forms.ToolStripMenuItem ajouterUnVisiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualSecretaria;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMédicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMédecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesMedecintoolTip;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualVisiteur;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.Label labelPrenom;
    }
}