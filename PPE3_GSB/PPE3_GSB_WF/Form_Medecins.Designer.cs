namespace PPE3_GSB_WF
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_coefNot = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_coefConf = new System.Windows.Forms.TextBox();
            this.tb_spe = new System.Windows.Forms.TextBox();
            this.lab_nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.praticienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
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
            this.lbl_lstMedecins.Location = new System.Drawing.Point(127, 21);
            this.lbl_lstMedecins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstMedecins.Name = "lbl_lstMedecins";
            this.lbl_lstMedecins.Size = new System.Drawing.Size(264, 31);
            this.lbl_lstMedecins.TabIndex = 24;
            this.lbl_lstMedecins.Text = "Liste des médecins";
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
            this.btn_Ajouter.Location = new System.Drawing.Point(107, 365);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_Quitter.Location = new System.Drawing.Point(107, 443);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.praticienBindingSource2;
            this.comboBox1.DisplayMember = "PRA_NOM";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "PRA_NOM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choisir un médecin parmi la liste";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(590, 151);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(125, 22);
            this.tb_nom.TabIndex = 27;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(741, 151);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.ReadOnly = true;
            this.tb_prenom.Size = new System.Drawing.Size(125, 22);
            this.tb_prenom.TabIndex = 28;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(521, 215);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.ReadOnly = true;
            this.tb_adresse.Size = new System.Drawing.Size(125, 22);
            this.tb_adresse.TabIndex = 29;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(667, 215);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.ReadOnly = true;
            this.tb_cp.Size = new System.Drawing.Size(125, 22);
            this.tb_cp.TabIndex = 30;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(816, 215);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.ReadOnly = true;
            this.tb_ville.Size = new System.Drawing.Size(125, 22);
            this.tb_ville.TabIndex = 31;
            // 
            // tb_coefNot
            // 
            this.tb_coefNot.Location = new System.Drawing.Point(667, 300);
            this.tb_coefNot.Name = "tb_coefNot";
            this.tb_coefNot.ReadOnly = true;
            this.tb_coefNot.Size = new System.Drawing.Size(37, 22);
            this.tb_coefNot.TabIndex = 32;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(720, 95);
            this.tb_num.Name = "tb_num";
            this.tb_num.ReadOnly = true;
            this.tb_num.Size = new System.Drawing.Size(36, 22);
            this.tb_num.TabIndex = 33;
            // 
            // tb_coefConf
            // 
            this.tb_coefConf.Location = new System.Drawing.Point(781, 300);
            this.tb_coefConf.Name = "tb_coefConf";
            this.tb_coefConf.ReadOnly = true;
            this.tb_coefConf.Size = new System.Drawing.Size(42, 22);
            this.tb_coefConf.TabIndex = 34;
            // 
            // tb_spe
            // 
            this.tb_spe.Location = new System.Drawing.Point(569, 380);
            this.tb_spe.Name = "tb_spe";
            this.tb_spe.ReadOnly = true;
            this.tb_spe.Size = new System.Drawing.Size(351, 22);
            this.tb_spe.TabIndex = 35;
            // 
            // lab_nom
            // 
            this.lab_nom.AutoSize = true;
            this.lab_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nom.Location = new System.Drawing.Point(565, 32);
            this.lab_nom.Name = "lab_nom";
            this.lab_nom.Size = new System.Drawing.Size(155, 20);
            this.lab_nom.TabIndex = 36;
            this.lab_nom.Text = "Nom du médecin ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prénom du médecin ";
            // 
            // praticienBindingSource2
            // 
            this.praticienBindingSource2.DataMember = "praticien";
            this.praticienBindingSource2.DataSource = this.gSB_PPE3DataSet1;
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
            // Form_Medecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_nom);
            this.Controls.Add(this.tb_spe);
            this.Controls.Add(this.tb_coefConf);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_coefNot);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_lstMedecins);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource praticienBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_coefNot;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_coefConf;
        private System.Windows.Forms.TextBox tb_spe;
        private System.Windows.Forms.Label lab_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}