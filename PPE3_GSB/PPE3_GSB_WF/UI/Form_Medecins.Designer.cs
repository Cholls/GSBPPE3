﻿namespace PPE3_GSB_WF
{
    partial class Form_Medecins
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
            this.lbl_lstMedecins = new System.Windows.Forms.Label();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.cb_Select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_coefNot = new System.Windows.Forms.TextBox();
            this.tb_coefConf = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.but_valid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_modif = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nb_praticien = new System.Windows.Forms.TextBox();
            this.panelPourAdmin = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_region = new System.Windows.Forms.ComboBox();
            this.labelpresentation = new System.Windows.Forms.Label();
            this.labelconnexion = new System.Windows.Forms.Label();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_valid_1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelPourAdmin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_lstMedecins
            // 
            this.lbl_lstMedecins.AutoSize = true;
            this.lbl_lstMedecins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstMedecins.Location = new System.Drawing.Point(1, 5);
            this.lbl_lstMedecins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstMedecins.Name = "lbl_lstMedecins";
            this.lbl_lstMedecins.Size = new System.Drawing.Size(368, 31);
            this.lbl_lstMedecins.TabIndex = 24;
            this.lbl_lstMedecins.Text = "Consultation des praticiens";
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(173, 530);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(283, 47);
            this.btn_Ajouter.TabIndex = 20;
            this.btn_Ajouter.Text = "Ajouter nouveau praticien";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(14, 530);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 18;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // cb_Select
            // 
            this.cb_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Select.FormattingEnabled = true;
            this.cb_Select.Location = new System.Drawing.Point(30, 118);
            this.cb_Select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(237, 24);
            this.cb_Select.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choisir une région";
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.Location = new System.Drawing.Point(607, 166);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nom.MaxLength = 35;
            this.tb_nom.Multiline = true;
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(172, 34);
            this.tb_nom.TabIndex = 1;
            this.tb_nom.WordWrap = false;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prenom.Location = new System.Drawing.Point(827, 166);
            this.tb_prenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_prenom.MaxLength = 35;
            this.tb_prenom.Multiline = true;
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.ReadOnly = true;
            this.tb_prenom.Size = new System.Drawing.Size(192, 34);
            this.tb_prenom.TabIndex = 2;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(505, 264);
            this.tb_adresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.ReadOnly = true;
            this.tb_adresse.Size = new System.Drawing.Size(267, 22);
            this.tb_adresse.TabIndex = 3;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(800, 264);
            this.tb_cp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.ReadOnly = true;
            this.tb_cp.Size = new System.Drawing.Size(76, 22);
            this.tb_cp.TabIndex = 4;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(913, 264);
            this.tb_ville.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.ReadOnly = true;
            this.tb_ville.Size = new System.Drawing.Size(184, 22);
            this.tb_ville.TabIndex = 5;
            // 
            // tb_coefNot
            // 
            this.tb_coefNot.Location = new System.Drawing.Point(730, 351);
            this.tb_coefNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_coefNot.Name = "tb_coefNot";
            this.tb_coefNot.ReadOnly = true;
            this.tb_coefNot.Size = new System.Drawing.Size(72, 22);
            this.tb_coefNot.TabIndex = 6;
            // 
            // tb_coefConf
            // 
            this.tb_coefConf.Location = new System.Drawing.Point(1045, 349);
            this.tb_coefConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_coefConf.Name = "tb_coefConf";
            this.tb_coefConf.ReadOnly = true;
            this.tb_coefConf.Size = new System.Drawing.Size(64, 22);
            this.tb_coefConf.TabIndex = 7;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(605, 415);
            this.tb_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_type.Name = "tb_type";
            this.tb_type.ReadOnly = true;
            this.tb_type.Size = new System.Drawing.Size(49, 22);
            this.tb_type.TabIndex = 8;
            // 
            // but_valid
            // 
            this.but_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_valid.Location = new System.Drawing.Point(85, 158);
            this.but_valid.Margin = new System.Windows.Forms.Padding(4);
            this.but_valid.Name = "but_valid";
            this.but_valid.Size = new System.Drawing.Size(139, 37);
            this.but_valid.TabIndex = 38;
            this.but_valid.Text = "Valider";
            this.but_valid.UseVisualStyleBackColor = true;
            this.but_valid.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nom du praticien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(823, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Prénom du praticien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(796, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Code postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(909, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Coefficient de notoriété";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(827, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Coefficient de confiance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Type";
            // 
            // btn_modif
            // 
            this.btn_modif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.Location = new System.Drawing.Point(543, 530);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(255, 47);
            this.btn_modif.TabIndex = 9;
            this.btn_modif.Text = "Valider les modifications";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(487, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(532, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Vous pouvez apporter des modifications aux informations renseignées";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(776, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Nombre de praticiens :";
            // 
            // txt_nb_praticien
            // 
            this.txt_nb_praticien.Location = new System.Drawing.Point(981, 14);
            this.txt_nb_praticien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nb_praticien.Name = "txt_nb_praticien";
            this.txt_nb_praticien.ReadOnly = true;
            this.txt_nb_praticien.Size = new System.Drawing.Size(39, 22);
            this.txt_nb_praticien.TabIndex = 50;
            // 
            // panelPourAdmin
            // 
            this.panelPourAdmin.Controls.Add(this.label12);
            this.panelPourAdmin.Controls.Add(this.cb_region);
            this.panelPourAdmin.Controls.Add(this.label1);
            this.panelPourAdmin.Controls.Add(this.cb_Select);
            this.panelPourAdmin.Controls.Add(this.but_valid);
            this.panelPourAdmin.Location = new System.Drawing.Point(30, 103);
            this.panelPourAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPourAdmin.Name = "panelPourAdmin";
            this.panelPourAdmin.Size = new System.Drawing.Size(357, 215);
            this.panelPourAdmin.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(321, 23);
            this.label12.TabIndex = 63;
            this.label12.Text = "Les praticiens de la région selectionnée";
            // 
            // cb_region
            // 
            this.cb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_region.FormattingEnabled = true;
            this.cb_region.Location = new System.Drawing.Point(30, 52);
            this.cb_region.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_region.Name = "cb_region";
            this.cb_region.Size = new System.Drawing.Size(237, 24);
            this.cb_region.TabIndex = 39;
            this.cb_region.SelectedIndexChanged += new System.EventHandler(this.cb_region_SelectedIndexChanged);
            // 
            // labelpresentation
            // 
            this.labelpresentation.AutoSize = true;
            this.labelpresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpresentation.Location = new System.Drawing.Point(583, 10);
            this.labelpresentation.Name = "labelpresentation";
            this.labelpresentation.Size = new System.Drawing.Size(118, 20);
            this.labelpresentation.TabIndex = 77;
            this.labelpresentation.Text = "Administrateur";
            // 
            // labelconnexion
            // 
            this.labelconnexion.AutoSize = true;
            this.labelconnexion.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconnexion.Location = new System.Drawing.Point(410, 9);
            this.labelconnexion.Name = "labelconnexion";
            this.labelconnexion.Size = new System.Drawing.Size(163, 23);
            this.labelconnexion.TabIndex = 76;
            this.labelconnexion.Text = "Connexion actuelle :";
            // 
            // btn_suppr
            // 
            this.btn_suppr.Enabled = false;
            this.btn_suppr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppr.Location = new System.Drawing.Point(859, 530);
            this.btn_suppr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(255, 47);
            this.btn_suppr.TabIndex = 78;
            this.btn_suppr.Text = "Supprimer";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_valid_1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb_recherche);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 136);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche par nom";
            // 
            // but_valid_1
            // 
            this.but_valid_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_valid_1.Location = new System.Drawing.Point(219, 83);
            this.but_valid_1.Margin = new System.Windows.Forms.Padding(4);
            this.but_valid_1.Name = "but_valid_1";
            this.but_valid_1.Size = new System.Drawing.Size(110, 34);
            this.but_valid_1.TabIndex = 63;
            this.but_valid_1.Text = "Valider";
            this.but_valid_1.UseVisualStyleBackColor = true;
            this.but_valid_1.Click += new System.EventHandler(this.but_valid_1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 23);
            this.label13.TabIndex = 43;
            this.label13.Text = "Tapez le nom recherché puis validez";
            // 
            // tb_recherche
            // 
            this.tb_recherche.Location = new System.Drawing.Point(23, 89);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(168, 28);
            this.tb_recherche.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(344, 23);
            this.label14.TabIndex = 41;
            this.label14.Text = "Vous cherchez un praticien en particulier ?";
            // 
            // Form_Medecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 701);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.labelpresentation);
            this.Controls.Add(this.labelconnexion);
            this.Controls.Add(this.panelPourAdmin);
            this.Controls.Add(this.txt_nb_praticien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_modif);
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
            this.Controls.Add(this.lbl_lstMedecins);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Medecins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medecins";
            this.Load += new System.EventHandler(this.Form_Medecins_Load);
            this.panelPourAdmin.ResumeLayout(false);
            this.panelPourAdmin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_lstMedecins;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Quitter;
   
        private System.Windows.Forms.ComboBox cb_Select;
  
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_coefNot;
        private System.Windows.Forms.TextBox tb_coefConf;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Button but_valid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nb_praticien;
        private System.Windows.Forms.Panel panelPourAdmin;
        private System.Windows.Forms.Label labelpresentation;
        private System.Windows.Forms.Label labelconnexion;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.ComboBox cb_region;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_valid_1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Label label14;
    }
}