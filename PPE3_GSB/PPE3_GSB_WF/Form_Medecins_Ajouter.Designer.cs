namespace PPE3_GSB_WF
{
    partial class Form_Medecins_Ajouter
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
            this.lbl_AjoutVisiteur = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.tb_Adresse = new System.Windows.Forms.TextBox();
            this.tb_CP = new System.Windows.Forms.TextBox();
            this.tb_Ville = new System.Windows.Forms.TextBox();
            this.tb_Matricule = new System.Windows.Forms.TextBox();
            this.lbl_DateEmbauche = new System.Windows.Forms.Label();
            this.lbl_Ville = new System.Windows.Forms.Label();
            this.lbl_CP = new System.Windows.Forms.Label();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_Matricule = new System.Windows.Forms.Label();
            this.cb_spe = new System.Windows.Forms.ComboBox();
            this.praticienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet6 = new PPE3_GSB_WF.GSB_PPE3DataSet6();
            this.specialiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet3 = new PPE3_GSB_WF.GSB_PPE3DataSet3();
            this.specialiteTableAdapter = new PPE3_GSB_WF.GSB_PPE3DataSet3TableAdapters.specialiteTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_coefNot = new System.Windows.Forms.TextBox();
            this.tb_coefConf = new System.Windows.Forms.TextBox();
            this.praticienTableAdapter = new PPE3_GSB_WF.GSB_PPE3DataSet6TableAdapters.praticienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AjoutVisiteur
            // 
            this.lbl_AjoutVisiteur.AutoSize = true;
            this.lbl_AjoutVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AjoutVisiteur.Location = new System.Drawing.Point(121, 9);
            this.lbl_AjoutVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AjoutVisiteur.Name = "lbl_AjoutVisiteur";
            this.lbl_AjoutVisiteur.Size = new System.Drawing.Size(264, 31);
            this.lbl_AjoutVisiteur.TabIndex = 38;
            this.lbl_AjoutVisiteur.Text = "Ajouter un médecin";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Annuler.Location = new System.Drawing.Point(66, 424);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(128, 47);
            this.btn_Annuler.TabIndex = 10;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Valider.Location = new System.Drawing.Point(287, 424);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(128, 47);
            this.btn_Valider.TabIndex = 11;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(160, 104);
            this.tb_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Nom.MaxLength = 20;
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(211, 22);
            this.tb_Nom.TabIndex = 2;
            this.tb_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nom_KeyPress);
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(160, 134);
            this.tb_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Prenom.MaxLength = 20;
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(211, 22);
            this.tb_Prenom.TabIndex = 3;
            this.tb_Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Prenom_KeyPress);
            // 
            // tb_Adresse
            // 
            this.tb_Adresse.Location = new System.Drawing.Point(160, 174);
            this.tb_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Adresse.MaxLength = 45;
            this.tb_Adresse.Name = "tb_Adresse";
            this.tb_Adresse.Size = new System.Drawing.Size(357, 22);
            this.tb_Adresse.TabIndex = 4;
            // 
            // tb_CP
            // 
            this.tb_CP.Location = new System.Drawing.Point(160, 212);
            this.tb_CP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CP.MaxLength = 5;
            this.tb_CP.Name = "tb_CP";
            this.tb_CP.Size = new System.Drawing.Size(91, 22);
            this.tb_CP.TabIndex = 5;
            this.tb_CP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CP_KeyPress);
            // 
            // tb_Ville
            // 
            this.tb_Ville.Location = new System.Drawing.Point(160, 247);
            this.tb_Ville.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ville.MaxLength = 45;
            this.tb_Ville.Name = "tb_Ville";
            this.tb_Ville.Size = new System.Drawing.Size(225, 22);
            this.tb_Ville.TabIndex = 6;
            this.tb_Ville.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Ville_KeyPress);
            // 
            // tb_Matricule
            // 
            this.tb_Matricule.Location = new System.Drawing.Point(204, 60);
            this.tb_Matricule.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Matricule.MaxLength = 10;
            this.tb_Matricule.Name = "tb_Matricule";
            this.tb_Matricule.Size = new System.Drawing.Size(97, 22);
            this.tb_Matricule.TabIndex = 1;
            // 
            // lbl_DateEmbauche
            // 
            this.lbl_DateEmbauche.AutoSize = true;
            this.lbl_DateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateEmbauche.Location = new System.Drawing.Point(15, 368);
            this.lbl_DateEmbauche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateEmbauche.Name = "lbl_DateEmbauche";
            this.lbl_DateEmbauche.Size = new System.Drawing.Size(97, 25);
            this.lbl_DateEmbauche.TabIndex = 67;
            this.lbl_DateEmbauche.Text = "Spécialité";
            // 
            // lbl_Ville
            // 
            this.lbl_Ville.AutoSize = true;
            this.lbl_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ville.Location = new System.Drawing.Point(15, 244);
            this.lbl_Ville.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ville.Name = "lbl_Ville";
            this.lbl_Ville.Size = new System.Drawing.Size(49, 25);
            this.lbl_Ville.TabIndex = 66;
            this.lbl_Ville.Text = "Ville";
            // 
            // lbl_CP
            // 
            this.lbl_CP.AutoSize = true;
            this.lbl_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CP.Location = new System.Drawing.Point(13, 208);
            this.lbl_CP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CP.Name = "lbl_CP";
            this.lbl_CP.Size = new System.Drawing.Size(117, 25);
            this.lbl_CP.TabIndex = 65;
            this.lbl_CP.Text = "Code postal";
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adresse.Location = new System.Drawing.Point(15, 171);
            this.lbl_Adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(85, 25);
            this.lbl_Adresse.TabIndex = 64;
            this.lbl_Adresse.Text = "Adresse";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prenom.Location = new System.Drawing.Point(15, 134);
            this.lbl_Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(80, 25);
            this.lbl_Prenom.TabIndex = 63;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.Location = new System.Drawing.Point(15, 98);
            this.lbl_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(53, 25);
            this.lbl_Nom.TabIndex = 62;
            this.lbl_Nom.Text = "Nom";
            // 
            // lbl_Matricule
            // 
            this.lbl_Matricule.AutoSize = true;
            this.lbl_Matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricule.Location = new System.Drawing.Point(13, 60);
            this.lbl_Matricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Matricule.Name = "lbl_Matricule";
            this.lbl_Matricule.Size = new System.Drawing.Size(160, 25);
            this.lbl_Matricule.TabIndex = 61;
            this.lbl_Matricule.Text = "Numéro medecin";
            // 
            // cb_spe
            // 
            this.cb_spe.DataSource = this.praticienBindingSource;
            this.cb_spe.DisplayMember = "TYP_CODE";
            this.cb_spe.FormattingEnabled = true;
            this.cb_spe.Location = new System.Drawing.Point(160, 369);
            this.cb_spe.Name = "cb_spe";
            this.cb_spe.Size = new System.Drawing.Size(57, 24);
            this.cb_spe.TabIndex = 9;
            this.cb_spe.ValueMember = "TYP_CODE";
            // 
            // praticienBindingSource
            // 
            this.praticienBindingSource.DataMember = "praticien";
            this.praticienBindingSource.DataSource = this.gSB_PPE3DataSet6;
            // 
            // gSB_PPE3DataSet6
            // 
            this.gSB_PPE3DataSet6.DataSetName = "GSB_PPE3DataSet6";
            this.gSB_PPE3DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialiteBindingSource
            // 
            this.specialiteBindingSource.DataMember = "specialite";
            this.specialiteBindingSource.DataSource = this.gSB_PPE3DataSet3;
            // 
            // gSB_PPE3DataSet3
            // 
            this.gSB_PPE3DataSet3.DataSetName = "GSB_PPE3DataSet3";
            this.gSB_PPE3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialiteTableAdapter
            // 
            this.specialiteTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Coefficient de notoriété(en %)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Coefficient de confiance (en %)";
            // 
            // tb_coefNot
            // 
            this.tb_coefNot.Location = new System.Drawing.Point(324, 285);
            this.tb_coefNot.Margin = new System.Windows.Forms.Padding(4);
            this.tb_coefNot.MaxLength = 5;
            this.tb_coefNot.Name = "tb_coefNot";
            this.tb_coefNot.Size = new System.Drawing.Size(91, 22);
            this.tb_coefNot.TabIndex = 7;
            // 
            // tb_coefConf
            // 
            this.tb_coefConf.Location = new System.Drawing.Point(324, 326);
            this.tb_coefConf.Margin = new System.Windows.Forms.Padding(4);
            this.tb_coefConf.MaxLength = 5;
            this.tb_coefConf.Name = "tb_coefConf";
            this.tb_coefConf.Size = new System.Drawing.Size(91, 22);
            this.tb_coefConf.TabIndex = 8;
            // 
            // praticienTableAdapter
            // 
            this.praticienTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Medecins_Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 494);
            this.Controls.Add(this.tb_coefConf);
            this.Controls.Add(this.tb_coefNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_spe);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.tb_Adresse);
            this.Controls.Add(this.tb_CP);
            this.Controls.Add(this.tb_Ville);
            this.Controls.Add(this.tb_Matricule);
            this.Controls.Add(this.lbl_DateEmbauche);
            this.Controls.Add(this.lbl_Ville);
            this.Controls.Add(this.lbl_CP);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.lbl_Matricule);
            this.Controls.Add(this.lbl_AjoutVisiteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Medecins_Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Medecins_Ajouter";
            this.Load += new System.EventHandler(this.Form_Medecins_Ajouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AjoutVisiteur;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.TextBox tb_Adresse;
        private System.Windows.Forms.TextBox tb_CP;
        private System.Windows.Forms.TextBox tb_Ville;
        private System.Windows.Forms.TextBox tb_Matricule;
        private System.Windows.Forms.Label lbl_DateEmbauche;
        private System.Windows.Forms.Label lbl_Ville;
        private System.Windows.Forms.Label lbl_CP;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Matricule;
        private System.Windows.Forms.ComboBox cb_spe;
        private GSB_PPE3DataSet3 gSB_PPE3DataSet3;
        private System.Windows.Forms.BindingSource specialiteBindingSource;
        private GSB_PPE3DataSet3TableAdapters.specialiteTableAdapter specialiteTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_coefNot;
        private System.Windows.Forms.TextBox tb_coefConf;
        private GSB_PPE3DataSet6 gSB_PPE3DataSet6;
        private System.Windows.Forms.BindingSource praticienBindingSource;
        private GSB_PPE3DataSet6TableAdapters.praticienTableAdapter praticienTableAdapter;
    }
}