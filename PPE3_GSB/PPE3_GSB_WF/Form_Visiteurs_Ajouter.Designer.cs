﻿namespace PPE3_GSB_WF
{
    partial class Form_Visiteurs_Ajouter
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
            this.tb_DateEmbauche = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.lbl_AjoutVisiteur = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.tb_MotDePasse = new System.Windows.Forms.TextBox();
            this.lbl_MotDePasse = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(179, 123);
            this.tb_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Nom.MaxLength = 15;
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(199, 22);
            this.tb_Nom.TabIndex = 2;
            this.tb_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nom_KeyPress);
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(176, 161);
            this.tb_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Prenom.MaxLength = 15;
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(199, 22);
            this.tb_Prenom.TabIndex = 3;
            this.tb_Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Prenom_KeyPress);
            // 
            // tb_Adresse
            // 
            this.tb_Adresse.Location = new System.Drawing.Point(179, 200);
            this.tb_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Adresse.MaxLength = 40;
            this.tb_Adresse.Multiline = true;
            this.tb_Adresse.Name = "tb_Adresse";
            this.tb_Adresse.Size = new System.Drawing.Size(331, 22);
            this.tb_Adresse.TabIndex = 4;
            // 
            // tb_CP
            // 
            this.tb_CP.Location = new System.Drawing.Point(176, 235);
            this.tb_CP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CP.MaxLength = 5;
            this.tb_CP.Name = "tb_CP";
            this.tb_CP.Size = new System.Drawing.Size(87, 22);
            this.tb_CP.TabIndex = 5;
            this.tb_CP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CP_KeyPress);
            // 
            // tb_Ville
            // 
            this.tb_Ville.Location = new System.Drawing.Point(179, 271);
            this.tb_Ville.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ville.MaxLength = 10;
            this.tb_Ville.Name = "tb_Ville";
            this.tb_Ville.Size = new System.Drawing.Size(199, 22);
            this.tb_Ville.TabIndex = 6;
            this.tb_Ville.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Ville_KeyPress);
            // 
            // tb_Matricule
            // 
            this.tb_Matricule.Location = new System.Drawing.Point(179, 86);
            this.tb_Matricule.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Matricule.MaxLength = 5;
            this.tb_Matricule.Name = "tb_Matricule";
            this.tb_Matricule.Size = new System.Drawing.Size(66, 22);
            this.tb_Matricule.TabIndex = 1;
            // 
            // lbl_DateEmbauche
            // 
            this.lbl_DateEmbauche.AutoSize = true;
            this.lbl_DateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateEmbauche.Location = new System.Drawing.Point(3, 307);
            this.lbl_DateEmbauche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateEmbauche.Name = "lbl_DateEmbauche";
            this.lbl_DateEmbauche.Size = new System.Drawing.Size(165, 25);
            this.lbl_DateEmbauche.TabIndex = 25;
            this.lbl_DateEmbauche.Text = "Date d\'embauche";
            // 
            // lbl_Ville
            // 
            this.lbl_Ville.AutoSize = true;
            this.lbl_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ville.Location = new System.Drawing.Point(7, 271);
            this.lbl_Ville.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ville.Name = "lbl_Ville";
            this.lbl_Ville.Size = new System.Drawing.Size(49, 25);
            this.lbl_Ville.TabIndex = 24;
            this.lbl_Ville.Text = "Ville";
            // 
            // lbl_CP
            // 
            this.lbl_CP.AutoSize = true;
            this.lbl_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CP.Location = new System.Drawing.Point(3, 231);
            this.lbl_CP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CP.Name = "lbl_CP";
            this.lbl_CP.Size = new System.Drawing.Size(117, 25);
            this.lbl_CP.TabIndex = 23;
            this.lbl_CP.Text = "Code postal";
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adresse.Location = new System.Drawing.Point(7, 196);
            this.lbl_Adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(85, 25);
            this.lbl_Adresse.TabIndex = 22;
            this.lbl_Adresse.Text = "Adresse";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prenom.Location = new System.Drawing.Point(3, 157);
            this.lbl_Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(80, 25);
            this.lbl_Prenom.TabIndex = 21;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.Location = new System.Drawing.Point(3, 123);
            this.lbl_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(53, 25);
            this.lbl_Nom.TabIndex = 20;
            this.lbl_Nom.Text = "Nom";
            // 
            // lbl_Matricule
            // 
            this.lbl_Matricule.AutoSize = true;
            this.lbl_Matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricule.Location = new System.Drawing.Point(7, 86);
            this.lbl_Matricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Matricule.Name = "lbl_Matricule";
            this.lbl_Matricule.Size = new System.Drawing.Size(91, 25);
            this.lbl_Matricule.TabIndex = 19;
            this.lbl_Matricule.Text = "Matricule";
            // 
            // tb_DateEmbauche
            // 
            this.tb_DateEmbauche.Location = new System.Drawing.Point(193, 307);
            this.tb_DateEmbauche.Margin = new System.Windows.Forms.Padding(4);
            this.tb_DateEmbauche.MaxLength = 8;
            this.tb_DateEmbauche.Name = "tb_DateEmbauche";
            this.tb_DateEmbauche.Size = new System.Drawing.Size(131, 22);
            this.tb_DateEmbauche.TabIndex = 7;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Valider.Location = new System.Drawing.Point(299, 431);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(128, 47);
            this.btn_Valider.TabIndex = 11;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // lbl_AjoutVisiteur
            // 
            this.lbl_AjoutVisiteur.AutoSize = true;
            this.lbl_AjoutVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AjoutVisiteur.Location = new System.Drawing.Point(128, 23);
            this.lbl_AjoutVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AjoutVisiteur.Name = "lbl_AjoutVisiteur";
            this.lbl_AjoutVisiteur.Size = new System.Drawing.Size(250, 31);
            this.lbl_AjoutVisiteur.TabIndex = 37;
            this.lbl_AjoutVisiteur.Text = "Ajouter un visiteur";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Annuler.Location = new System.Drawing.Point(79, 431);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(128, 47);
            this.btn_Annuler.TabIndex = 10;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // tb_MotDePasse
            // 
            this.tb_MotDePasse.Location = new System.Drawing.Point(176, 384);
            this.tb_MotDePasse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MotDePasse.MaxLength = 10;
            this.tb_MotDePasse.Name = "tb_MotDePasse";
            this.tb_MotDePasse.Size = new System.Drawing.Size(183, 22);
            this.tb_MotDePasse.TabIndex = 9;
            // 
            // lbl_MotDePasse
            // 
            this.lbl_MotDePasse.AutoSize = true;
            this.lbl_MotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MotDePasse.Location = new System.Drawing.Point(3, 381);
            this.lbl_MotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MotDePasse.Name = "lbl_MotDePasse";
            this.lbl_MotDePasse.Size = new System.Drawing.Size(130, 25);
            this.lbl_MotDePasse.TabIndex = 27;
            this.lbl_MotDePasse.Text = "Mot de passe";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(176, 347);
            this.tb_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Login.MaxLength = 10;
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(183, 22);
            this.tb_Login.TabIndex = 8;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(7, 344);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(60, 25);
            this.lbl_Login.TabIndex = 26;
            this.lbl_Login.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(376, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Caractères max : 10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(376, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Caractères max : 10";
            // 
            // Form_Visiteurs_Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.lbl_AjoutVisiteur);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.tb_Adresse);
            this.Controls.Add(this.tb_CP);
            this.Controls.Add(this.tb_Ville);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.tb_MotDePasse);
            this.Controls.Add(this.tb_Matricule);
            this.Controls.Add(this.lbl_MotDePasse);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_DateEmbauche);
            this.Controls.Add(this.lbl_Ville);
            this.Controls.Add(this.lbl_CP);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.lbl_Matricule);
            this.Controls.Add(this.tb_DateEmbauche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Visiteurs_Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Visiteurs_Ajouter";
            this.Load += new System.EventHandler(this.Form_Visiteurs_Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox tb_DateEmbauche;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Label lbl_AjoutVisiteur;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.TextBox tb_MotDePasse;
        private System.Windows.Forms.Label lbl_MotDePasse;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}