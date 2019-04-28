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
            this.lbl_AjoutVisiteur = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.tb_Adresse = new System.Windows.Forms.TextBox();
            this.tb_CP = new System.Windows.Forms.TextBox();
            this.tb_Ville = new System.Windows.Forms.TextBox();
            this.lbl_DateEmbauche = new System.Windows.Forms.Label();
            this.lbl_Ville = new System.Windows.Forms.Label();
            this.lbl_CP = new System.Windows.Forms.Label();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_coefNot = new System.Windows.Forms.TextBox();
            this.tb_coefConf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_region = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_AjoutVisiteur
            // 
            this.lbl_AjoutVisiteur.AutoSize = true;
            this.lbl_AjoutVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AjoutVisiteur.Location = new System.Drawing.Point(121, 9);
            this.lbl_AjoutVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AjoutVisiteur.Name = "lbl_AjoutVisiteur";
            this.lbl_AjoutVisiteur.Size = new System.Drawing.Size(267, 31);
            this.lbl_AjoutVisiteur.TabIndex = 38;
            this.lbl_AjoutVisiteur.Text = "Ajouter un praticien";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Annuler.Location = new System.Drawing.Point(63, 518);
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
            this.btn_Valider.Location = new System.Drawing.Point(287, 518);
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
            this.tb_Nom.Location = new System.Drawing.Point(158, 78);
            this.tb_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Nom.MaxLength = 20;
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(211, 22);
            this.tb_Nom.TabIndex = 2;
            this.tb_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nom_KeyPress);
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(158, 109);
            this.tb_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Prenom.MaxLength = 20;
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(211, 22);
            this.tb_Prenom.TabIndex = 3;
            this.tb_Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Prenom_KeyPress);
            // 
            // tb_Adresse
            // 
            this.tb_Adresse.Location = new System.Drawing.Point(158, 149);
            this.tb_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Adresse.MaxLength = 45;
            this.tb_Adresse.Name = "tb_Adresse";
            this.tb_Adresse.Size = new System.Drawing.Size(357, 22);
            this.tb_Adresse.TabIndex = 4;
            // 
            // tb_CP
            // 
            this.tb_CP.Location = new System.Drawing.Point(158, 187);
            this.tb_CP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CP.MaxLength = 5;
            this.tb_CP.Name = "tb_CP";
            this.tb_CP.Size = new System.Drawing.Size(91, 22);
            this.tb_CP.TabIndex = 5;
            this.tb_CP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CP_KeyPress);
            // 
            // tb_Ville
            // 
            this.tb_Ville.Location = new System.Drawing.Point(158, 222);
            this.tb_Ville.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ville.MaxLength = 45;
            this.tb_Ville.Name = "tb_Ville";
            this.tb_Ville.Size = new System.Drawing.Size(225, 22);
            this.tb_Ville.TabIndex = 6;
            this.tb_Ville.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Ville_KeyPress);
            // 
            // lbl_DateEmbauche
            // 
            this.lbl_DateEmbauche.AutoSize = true;
            this.lbl_DateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateEmbauche.Location = new System.Drawing.Point(13, 346);
            this.lbl_DateEmbauche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateEmbauche.Name = "lbl_DateEmbauche";
            this.lbl_DateEmbauche.Size = new System.Drawing.Size(162, 25);
            this.lbl_DateEmbauche.TabIndex = 67;
            this.lbl_DateEmbauche.Text = "Type de praticien";
            // 
            // lbl_Ville
            // 
            this.lbl_Ville.AutoSize = true;
            this.lbl_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ville.Location = new System.Drawing.Point(13, 219);
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
            this.lbl_CP.Location = new System.Drawing.Point(11, 183);
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
            this.lbl_Adresse.Location = new System.Drawing.Point(13, 146);
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
            this.lbl_Prenom.Location = new System.Drawing.Point(13, 109);
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
            this.lbl_Nom.Location = new System.Drawing.Point(13, 73);
            this.lbl_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(53, 25);
            this.lbl_Nom.TabIndex = 62;
            this.lbl_Nom.Text = "Nom";
            // 
            // cb_type
            // 
            this.cb_type.DisplayMember = "TYP_CODE";
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(16, 373);
            this.cb_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(384, 24);
            this.cb_type.TabIndex = 9;
            this.cb_type.ValueMember = "TYP_CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Coefficient de confiance (en %)";
            // 
            // tb_coefNot
            // 
            this.tb_coefNot.Location = new System.Drawing.Point(322, 261);
            this.tb_coefNot.Margin = new System.Windows.Forms.Padding(4);
            this.tb_coefNot.MaxLength = 5;
            this.tb_coefNot.Name = "tb_coefNot";
            this.tb_coefNot.Size = new System.Drawing.Size(91, 22);
            this.tb_coefNot.TabIndex = 7;
            this.tb_coefNot.TextChanged += new System.EventHandler(this.tb_coefNot_TextChanged);
            // 
            // tb_coefConf
            // 
            this.tb_coefConf.Location = new System.Drawing.Point(322, 301);
            this.tb_coefConf.Margin = new System.Windows.Forms.Padding(4);
            this.tb_coefConf.MaxLength = 5;
            this.tb_coefConf.Name = "tb_coefConf";
            this.tb_coefConf.Size = new System.Drawing.Size(91, 22);
            this.tb_coefConf.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Coefficient de notoriété (en %)";
            // 
            // cb_region
            // 
            this.cb_region.DisplayMember = "TYP_CODE";
            this.cb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_region.FormattingEnabled = true;
            this.cb_region.Location = new System.Drawing.Point(16, 442);
            this.cb_region.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_region.Name = "cb_region";
            this.cb_region.Size = new System.Drawing.Size(270, 24);
            this.cb_region.TabIndex = 71;
            this.cb_region.ValueMember = "TYP_CODE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Région";
            // 
            // Form_Medecins_Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 578);
            this.Controls.Add(this.cb_region);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_coefConf);
            this.Controls.Add(this.tb_coefNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.tb_Adresse);
            this.Controls.Add(this.tb_CP);
            this.Controls.Add(this.tb_Ville);
            this.Controls.Add(this.lbl_DateEmbauche);
            this.Controls.Add(this.lbl_Ville);
            this.Controls.Add(this.lbl_CP);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.lbl_AjoutVisiteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Medecins_Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un médecin";
            this.Load += new System.EventHandler(this.Form_Medecins_Ajouter_Load);
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
        private System.Windows.Forms.Label lbl_DateEmbauche;
        private System.Windows.Forms.Label lbl_Ville;
        private System.Windows.Forms.Label lbl_CP;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.ComboBox cb_type;


 
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_coefNot;
        private System.Windows.Forms.TextBox tb_coefConf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_region;
        private System.Windows.Forms.Label label4;
    }
}