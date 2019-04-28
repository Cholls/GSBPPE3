namespace PPE3_GSB_WF.UI
{
    partial class Form_Medecins_Visiteur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.valid_selection = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_coefConf = new System.Windows.Forms.TextBox();
            this.tb_coefNot = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.lbl_lstMedecins = new System.Windows.Forms.Label();
            this.labelconnexion = new System.Windows.Forms.Label();
            this.labelpresentation = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.txt_nb_praticien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cb_select);
            this.panel1.Controls.Add(this.valid_selection);
            this.panel1.Location = new System.Drawing.Point(19, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 257);
            this.panel1.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(323, 23);
            this.label13.TabIndex = 39;
            this.label13.Text = "Seuls ceux de votre région sont affichés";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Choisir un praticien";
            // 
            // cb_select
            // 
            this.cb_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(48, 96);
            this.cb_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(237, 24);
            this.cb_select.TabIndex = 25;
            // 
            // valid_selection
            // 
            this.valid_selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_selection.Location = new System.Drawing.Point(93, 138);
            this.valid_selection.Margin = new System.Windows.Forms.Padding(4);
            this.valid_selection.Name = "valid_selection";
            this.valid_selection.Size = new System.Drawing.Size(139, 47);
            this.valid_selection.TabIndex = 38;
            this.valid_selection.Text = "Valider";
            this.valid_selection.UseVisualStyleBackColor = true;
            this.valid_selection.Click += new System.EventHandler(this.valid_selection_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(532, 20);
            this.label10.TabIndex = 71;
            this.label10.Text = "Vous pouvez apporter des modifications aux informations renseignées";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 70;
            this.label9.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(765, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 23);
            this.label8.TabIndex = 69;
            this.label8.Text = "Coefficient de confiance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 68;
            this.label7.Text = "Coefficient de notoriété";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(880, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 67;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(768, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Code postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(808, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 64;
            this.label3.Text = "Prénom du praticien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nom du praticien";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(517, 419);
            this.tb_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_type.Name = "tb_type";
            this.tb_type.ReadOnly = true;
            this.tb_type.Size = new System.Drawing.Size(49, 22);
            this.tb_type.TabIndex = 61;
            // 
            // tb_coefConf
            // 
            this.tb_coefConf.Location = new System.Drawing.Point(985, 355);
            this.tb_coefConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_coefConf.Name = "tb_coefConf";
            this.tb_coefConf.ReadOnly = true;
            this.tb_coefConf.Size = new System.Drawing.Size(64, 22);
            this.tb_coefConf.TabIndex = 60;
            // 
            // tb_coefNot
            // 
            this.tb_coefNot.Location = new System.Drawing.Point(644, 355);
            this.tb_coefNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_coefNot.Name = "tb_coefNot";
            this.tb_coefNot.ReadOnly = true;
            this.tb_coefNot.Size = new System.Drawing.Size(72, 22);
            this.tb_coefNot.TabIndex = 59;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(884, 270);
            this.tb_ville.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.ReadOnly = true;
            this.tb_ville.Size = new System.Drawing.Size(184, 22);
            this.tb_ville.TabIndex = 58;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(770, 270);
            this.tb_cp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.ReadOnly = true;
            this.tb_cp.Size = new System.Drawing.Size(76, 22);
            this.tb_cp.TabIndex = 57;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(476, 270);
            this.tb_adresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.ReadOnly = true;
            this.tb_adresse.Size = new System.Drawing.Size(267, 22);
            this.tb_adresse.TabIndex = 56;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prenom.Location = new System.Drawing.Point(812, 149);
            this.tb_prenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_prenom.MaxLength = 35;
            this.tb_prenom.Multiline = true;
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.ReadOnly = true;
            this.tb_prenom.Size = new System.Drawing.Size(192, 34);
            this.tb_prenom.TabIndex = 55;
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.Location = new System.Drawing.Point(592, 149);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nom.MaxLength = 35;
            this.tb_nom.Multiline = true;
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(172, 34);
            this.tb_nom.TabIndex = 54;
            this.tb_nom.WordWrap = false;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(208, 530);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(139, 47);
            this.btn_Ajouter.TabIndex = 73;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(19, 529);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 72;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // lbl_lstMedecins
            // 
            this.lbl_lstMedecins.AutoSize = true;
            this.lbl_lstMedecins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstMedecins.Location = new System.Drawing.Point(15, 9);
            this.lbl_lstMedecins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstMedecins.Name = "lbl_lstMedecins";
            this.lbl_lstMedecins.Size = new System.Drawing.Size(368, 31);
            this.lbl_lstMedecins.TabIndex = 40;
            this.lbl_lstMedecins.Text = "Consultation des praticiens";
            // 
            // labelconnexion
            // 
            this.labelconnexion.AutoSize = true;
            this.labelconnexion.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconnexion.Location = new System.Drawing.Point(12, 50);
            this.labelconnexion.Name = "labelconnexion";
            this.labelconnexion.Size = new System.Drawing.Size(163, 23);
            this.labelconnexion.TabIndex = 74;
            this.labelconnexion.Text = "Connexion actuelle :";
            // 
            // labelpresentation
            // 
            this.labelpresentation.AutoSize = true;
            this.labelpresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpresentation.Location = new System.Drawing.Point(187, 52);
            this.labelpresentation.Name = "labelpresentation";
            this.labelpresentation.Size = new System.Drawing.Size(66, 20);
            this.labelpresentation.TabIndex = 75;
            this.labelpresentation.Text = "Visiteur";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(27, 89);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(44, 21);
            this.labelNom.TabIndex = 76;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(133, 89);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(65, 21);
            this.labelPrenom.TabIndex = 77;
            this.labelPrenom.Text = "Prenom";
            // 
            // btn_suppr
            // 
            this.btn_suppr.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppr.Location = new System.Drawing.Point(812, 516);
            this.btn_suppr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(255, 47);
            this.btn_suppr.TabIndex = 80;
            this.btn_suppr.Text = "Supprimer le praticien sélectionné";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click);
            // 
            // btn_modif
            // 
            this.btn_modif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.Location = new System.Drawing.Point(516, 516);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(255, 47);
            this.btn_modif.TabIndex = 79;
            this.btn_modif.Text = "Valider les modifications";
            this.btn_modif.UseVisualStyleBackColor = true;
            // 
            // txt_nb_praticien
            // 
            this.txt_nb_praticien.Location = new System.Drawing.Point(824, 18);
            this.txt_nb_praticien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nb_praticien.Name = "txt_nb_praticien";
            this.txt_nb_praticien.ReadOnly = true;
            this.txt_nb_praticien.Size = new System.Drawing.Size(53, 22);
            this.txt_nb_praticien.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(624, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 20);
            this.label11.TabIndex = 81;
            this.label11.Text = "Nombre de praticiens :";
            // 
            // Form_Medecins_Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 590);
            this.Controls.Add(this.txt_nb_praticien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelpresentation);
            this.Controls.Add(this.labelconnexion);
            this.Controls.Add(this.lbl_lstMedecins);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_coefConf);
            this.Controls.Add(this.tb_coefNot);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Medecins_Visiteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultation des praticiens ";
            this.Load += new System.EventHandler(this.Form_Medecins_Visiteur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Button valid_selection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_coefConf;
        private System.Windows.Forms.TextBox tb_coefNot;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Label lbl_lstMedecins;
        private System.Windows.Forms.Label labelconnexion;
        private System.Windows.Forms.Label labelpresentation;
        public System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.TextBox txt_nb_praticien;
        private System.Windows.Forms.Label label11;
    }
}