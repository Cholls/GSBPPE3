﻿namespace PPE3_GSB_WF
{
    partial class Form_Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_MotDePasse = new System.Windows.Forms.TextBox();
            this.tb_Identifiant = new System.Windows.Forms.TextBox();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.lbl_Identifiant = new System.Windows.Forms.Label();
            this.lbl_MotDePasse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MotDePasse
            // 
            this.tb_MotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MotDePasse.Location = new System.Drawing.Point(396, 198);
            this.tb_MotDePasse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MotDePasse.Name = "tb_MotDePasse";
            this.tb_MotDePasse.Size = new System.Drawing.Size(132, 27);
            this.tb_MotDePasse.TabIndex = 2;
            this.tb_MotDePasse.UseSystemPasswordChar = true;
            // 
            // tb_Identifiant
            // 
            this.tb_Identifiant.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Identifiant.Location = new System.Drawing.Point(107, 198);
            this.tb_Identifiant.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Identifiant.Name = "tb_Identifiant";
            this.tb_Identifiant.Size = new System.Drawing.Size(132, 28);
            this.tb_Identifiant.TabIndex = 1;
            this.tb_Identifiant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Identifiant_KeyPress);
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(168, 261);
            this.btn_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(100, 28);
            this.btn_Fermer.TabIndex = 5;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Connexion.Location = new System.Drawing.Point(332, 261);
            this.btn_Connexion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(100, 28);
            this.btn_Connexion.TabIndex = 4;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // lbl_Identifiant
            // 
            this.lbl_Identifiant.AutoSize = true;
            this.lbl_Identifiant.Location = new System.Drawing.Point(28, 202);
            this.lbl_Identifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Identifiant.Name = "lbl_Identifiant";
            this.lbl_Identifiant.Size = new System.Drawing.Size(69, 17);
            this.lbl_Identifiant.TabIndex = 8;
            this.lbl_Identifiant.Text = "Identifiant";
            // 
            // lbl_MotDePasse
            // 
            this.lbl_MotDePasse.AutoSize = true;
            this.lbl_MotDePasse.Location = new System.Drawing.Point(293, 202);
            this.lbl_MotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MotDePasse.Name = "lbl_MotDePasse";
            this.lbl_MotDePasse.Size = new System.Drawing.Size(93, 17);
            this.lbl_MotDePasse.TabIndex = 9;
            this.lbl_MotDePasse.Text = "Mot de passe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_GSB_WF.Properties.Resources.logogsb;
            this.pictureBox1.Location = new System.Drawing.Point(153, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_MotDePasse);
            this.Controls.Add(this.lbl_Identifiant);
            this.Controls.Add(this.tb_MotDePasse);
            this.Controls.Add(this.tb_Identifiant);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.btn_Connexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MotDePasse;
        private System.Windows.Forms.TextBox tb_Identifiant;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.Label lbl_Identifiant;
        private System.Windows.Forms.Label lbl_MotDePasse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

