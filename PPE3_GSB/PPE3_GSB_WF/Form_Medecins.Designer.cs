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
            this.components = new System.ComponentModel.Container();
            this.lbl_lstMedecins = new System.Windows.Forms.Label();
            this.praticienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet2 = new PPE3_GSB_WF.GSB_PPE3DataSet2();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.praticienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet1 = new PPE3_GSB_WF.GSB_PPE3DataSet1();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.eCOLECONDUITEDataSet = new PPE3_GSB_WF.ECOLECONDUITEDataSet();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLEVETableAdapter = new PPE3_GSB_WF.ECOLECONDUITEDataSetTableAdapters.ELEVETableAdapter();
            this.praticienTableAdapter = new PPE3_GSB_WF.GSB_PPE3DataSet1TableAdapters.praticienTableAdapter();
            this.praticienTableAdapter1 = new PPE3_GSB_WF.GSB_PPE3DataSet2TableAdapters.praticienTableAdapter();
            this.cb_Select = new System.Windows.Forms.ComboBox();
            this.praticienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_coefNot = new System.Windows.Forms.TextBox();
            this.tb_coefConf = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCOLECONDUITEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lstMedecins
            // 
            this.lbl_lstMedecins.AutoSize = true;
            this.lbl_lstMedecins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstMedecins.Location = new System.Drawing.Point(16, 21);
            this.lbl_lstMedecins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstMedecins.Name = "lbl_lstMedecins";
            this.lbl_lstMedecins.Size = new System.Drawing.Size(406, 31);
            this.lbl_lstMedecins.TabIndex = 24;
            this.lbl_lstMedecins.Text = "Consultation fiche de médecin";
            // 
            // praticienBindingSource1
            // 
            this.praticienBindingSource1.DataMember = "praticien";
            this.praticienBindingSource1.DataSource = this.gSB_PPE3DataSet2;
            // 
            // gSB_PPE3DataSet2
            // 
            this.gSB_PPE3DataSet2.DataSetName = "GSB_PPE3DataSet2";
            this.gSB_PPE3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(33, 365);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(139, 47);
            this.btn_Ajouter.TabIndex = 20;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // praticienBindingSource
            // 
            this.praticienBindingSource.DataMember = "praticien";
            this.praticienBindingSource.DataSource = this.gSB_PPE3DataSet1;
            // 
            // gSB_PPE3DataSet1
            // 
            this.gSB_PPE3DataSet1.DataSetName = "GSB_PPE3DataSet1";
            this.gSB_PPE3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(33, 442);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 18;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // eCOLECONDUITEDataSet
            // 
            this.eCOLECONDUITEDataSet.DataSetName = "ECOLECONDUITEDataSet";
            this.eCOLECONDUITEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLEVEBindingSource
            // 
            this.eLEVEBindingSource.DataMember = "ELEVE";
            this.eLEVEBindingSource.DataSource = this.eCOLECONDUITEDataSet;
            // 
            // eLEVETableAdapter
            // 
            this.eLEVETableAdapter.ClearBeforeFill = true;
            // 
            // praticienTableAdapter
            // 
            this.praticienTableAdapter.ClearBeforeFill = true;
            // 
            // praticienTableAdapter1
            // 
            this.praticienTableAdapter1.ClearBeforeFill = true;
            // 
            // cb_Select
            // 
            this.cb_Select.FormattingEnabled = true;
            this.cb_Select.Location = new System.Drawing.Point(43, 138);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(237, 24);
            this.cb_Select.TabIndex = 25;
            // 
            // praticienBindingSource2
            // 
            this.praticienBindingSource2.DataMember = "praticien";
            this.praticienBindingSource2.DataSource = this.gSB_PPE3DataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choisir un médecin parmi la liste";
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.Location = new System.Drawing.Point(543, 128);
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
            this.tb_prenom.Location = new System.Drawing.Point(763, 128);
            this.tb_prenom.MaxLength = 35;
            this.tb_prenom.Multiline = true;
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.ReadOnly = true;
            this.tb_prenom.Size = new System.Drawing.Size(192, 34);
            this.tb_prenom.TabIndex = 2;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(401, 215);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.ReadOnly = true;
            this.tb_adresse.Size = new System.Drawing.Size(267, 22);
            this.tb_adresse.TabIndex = 3;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(696, 215);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.ReadOnly = true;
            this.tb_cp.Size = new System.Drawing.Size(76, 22);
            this.tb_cp.TabIndex = 4;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(809, 215);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.ReadOnly = true;
            this.tb_ville.Size = new System.Drawing.Size(184, 22);
            this.tb_ville.TabIndex = 5;
            // 
            // tb_coefNot
            // 
            this.tb_coefNot.Location = new System.Drawing.Point(558, 300);
            this.tb_coefNot.Name = "tb_coefNot";
            this.tb_coefNot.ReadOnly = true;
            this.tb_coefNot.Size = new System.Drawing.Size(72, 22);
            this.tb_coefNot.TabIndex = 6;
            // 
            // tb_coefConf
            // 
            this.tb_coefConf.Location = new System.Drawing.Point(910, 300);
            this.tb_coefConf.Name = "tb_coefConf";
            this.tb_coefConf.ReadOnly = true;
            this.tb_coefConf.Size = new System.Drawing.Size(64, 22);
            this.tb_coefConf.TabIndex = 7;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(442, 365);
            this.tb_type.Name = "tb_type";
            this.tb_type.ReadOnly = true;
            this.tb_type.Size = new System.Drawing.Size(50, 22);
            this.tb_type.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 38;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nom du médecin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Prénom du médecin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Code postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(805, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Coefficient de notoriété";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Coefficient de confiance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Type";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(633, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Valider les modifications";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(532, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Vous pouvez apporter des modifications aux informations renseignées";
            // 
            // Form_Medecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 523);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_coefConf);
            this.Controls.Add(this.tb_coefNot);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Select);
            this.Controls.Add(this.lbl_lstMedecins);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Medecins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medecins";
            this.Load += new System.EventHandler(this.Form_Medecins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCOLECONDUITEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_lstMedecins;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Quitter;
        private ECOLECONDUITEDataSet eCOLECONDUITEDataSet;
        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        private ECOLECONDUITEDataSetTableAdapters.ELEVETableAdapter eLEVETableAdapter;
        private GSB_PPE3DataSet1 gSB_PPE3DataSet1;
        private System.Windows.Forms.BindingSource praticienBindingSource;
        private GSB_PPE3DataSet1TableAdapters.praticienTableAdapter praticienTableAdapter;
        private GSB_PPE3DataSet2 gSB_PPE3DataSet2;
        private System.Windows.Forms.BindingSource praticienBindingSource1;
        private GSB_PPE3DataSet2TableAdapters.praticienTableAdapter praticienTableAdapter1;
        private System.Windows.Forms.ComboBox cb_Select;
        private System.Windows.Forms.BindingSource praticienBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_coefNot;
        private System.Windows.Forms.TextBox tb_coefConf;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}