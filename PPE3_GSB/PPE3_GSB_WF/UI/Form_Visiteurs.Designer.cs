namespace PPE3_GSB_WF
{
    partial class Form_Visiteurs
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
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.lbl_lstVisiteurs = new System.Windows.Forms.Label();
            this.bt_valid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dateEmbauche = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_region = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_visiteur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(13, 529);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 0;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(286, 529);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(136, 48);
            this.btn_Ajouter.TabIndex = 2;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // lbl_lstVisiteurs
            // 
            this.lbl_lstVisiteurs.AutoSize = true;
            this.lbl_lstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstVisiteurs.Location = new System.Drawing.Point(7, 4);
            this.lbl_lstVisiteurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstVisiteurs.Name = "lbl_lstVisiteurs";
            this.lbl_lstVisiteurs.Size = new System.Drawing.Size(351, 31);
            this.lbl_lstVisiteurs.TabIndex = 6;
            this.lbl_lstVisiteurs.Text = "Consultation des visiteurs";
            // 
            // bt_valid
            // 
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.Location = new System.Drawing.Point(73, 190);
            this.bt_valid.Margin = new System.Windows.Forms.Padding(4);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(139, 36);
            this.bt_valid.TabIndex = 41;
            this.bt_valid.Text = "Valider";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Choisir une région";
            // 
            // cb_select
            // 
            this.cb_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(27, 140);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(237, 29);
            this.cb_select.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(780, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "Date d\'embauche";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(929, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Code postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(815, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Prénom du visiteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nom du visiteur";
            // 
            // tb_dateEmbauche
            // 
            this.tb_dateEmbauche.Location = new System.Drawing.Point(945, 357);
            this.tb_dateEmbauche.MaxLength = 12;
            this.tb_dateEmbauche.Name = "tb_dateEmbauche";
            this.tb_dateEmbauche.ReadOnly = true;
            this.tb_dateEmbauche.Size = new System.Drawing.Size(86, 22);
            this.tb_dateEmbauche.TabIndex = 6;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(552, 357);
            this.tb_ville.MaxLength = 20;
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.ReadOnly = true;
            this.tb_ville.Size = new System.Drawing.Size(211, 22);
            this.tb_ville.TabIndex = 5;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(933, 270);
            this.tb_cp.MaxLength = 5;
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.ReadOnly = true;
            this.tb_cp.Size = new System.Drawing.Size(76, 22);
            this.tb_cp.TabIndex = 4;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(488, 270);
            this.tb_adresse.MaxLength = 45;
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.ReadOnly = true;
            this.tb_adresse.Size = new System.Drawing.Size(402, 22);
            this.tb_adresse.TabIndex = 3;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prenom.Location = new System.Drawing.Point(819, 156);
            this.tb_prenom.MaxLength = 35;
            this.tb_prenom.Multiline = true;
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.ReadOnly = true;
            this.tb_prenom.Size = new System.Drawing.Size(199, 32);
            this.tb_prenom.TabIndex = 2;
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.Location = new System.Drawing.Point(578, 156);
            this.tb_nom.MaxLength = 35;
            this.tb_nom.Multiline = true;
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(179, 32);
            this.tb_nom.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(748, 462);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 102);
            this.button2.TabIndex = 7;
            this.button2.Text = "Valider les modifications";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_region
            // 
            this.cb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_region.FormattingEnabled = true;
            this.cb_region.Location = new System.Drawing.Point(23, 52);
            this.cb_region.Name = "cb_region";
            this.cb_region.Size = new System.Drawing.Size(237, 29);
            this.cb_region.TabIndex = 61;
            this.cb_region.SelectedIndexChanged += new System.EventHandler(this.cb_region_SelectedIndexChanged);
            this.cb_region.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_region_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 23);
            this.label8.TabIndex = 62;
            this.label8.Text = "Les visiteurs de la région selectionnée";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(574, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 63;
            this.label9.Text = "Il y a actuellement : ";
            // 
            // tx_visiteur
            // 
            this.tx_visiteur.Location = new System.Drawing.Point(756, 21);
            this.tx_visiteur.Name = "tx_visiteur";
            this.tx_visiteur.ReadOnly = true;
            this.tx_visiteur.Size = new System.Drawing.Size(52, 22);
            this.tx_visiteur.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(832, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 65;
            this.label10.Text = "visiteurs.";
            // 
            // btn_suppr
            // 
            this.btn_suppr.Enabled = false;
            this.btn_suppr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppr.Location = new System.Drawing.Point(976, 462);
            this.btn_suppr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(114, 102);
            this.btn_suppr.TabIndex = 79;
            this.btn_suppr.Text = "Supprimer";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_select);
            this.groupBox1.Controls.Add(this.bt_valid);
            this.groupBox1.Controls.Add(this.cb_region);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 259);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par région";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_recherche);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 150);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche par nom";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 63;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(425, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tapez le nom de la personne recherchée puis validez";
            // 
            // tb_recherche
            // 
            this.tb_recherche.Location = new System.Drawing.Point(9, 89);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(168, 28);
            this.tb_recherche.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 23);
            this.label11.TabIndex = 41;
            this.label11.Text = "Vous cherchez un visiteur en particulier ?";
            // 
            // Form_Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tx_visiteur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dateEmbauche);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.lbl_lstVisiteurs);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Visiteurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.Form_Visiteurs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Label lbl_lstVisiteurs;
       
    
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dateEmbauche;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_region;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tx_visiteur;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tb_nom;
    }
}