namespace PPE3_GSB_WF
{
    partial class Form_Medicament_Ajouter
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
            this.tb_Compo = new System.Windows.Forms.TextBox();
            this.lblComposition = new System.Windows.Forms.Label();
            this.tb_contreIndic = new System.Windows.Forms.RichTextBox();
            this.tb_effets = new System.Windows.Forms.RichTextBox();
            this.cb_famille = new System.Windows.Forms.ComboBox();
            this.lbl_Famille = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Matricule = new System.Windows.Forms.TextBox();
            this.lbl_contreIndic = new System.Windows.Forms.Label();
            this.lbl_Effets = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_Matricule = new System.Windows.Forms.Label();
            this.lbl_AjoutMedicament = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Compo
            // 
            this.tb_Compo.Location = new System.Drawing.Point(160, 186);
            this.tb_Compo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Compo.MaxLength = 15;
            this.tb_Compo.Name = "tb_Compo";
            this.tb_Compo.Size = new System.Drawing.Size(331, 22);
            this.tb_Compo.TabIndex = 4;
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposition.Location = new System.Drawing.Point(22, 183);
            this.lblComposition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(121, 25);
            this.lblComposition.TabIndex = 107;
            this.lblComposition.Text = "Composition";
            // 
            // tb_contreIndic
            // 
            this.tb_contreIndic.Location = new System.Drawing.Point(204, 331);
            this.tb_contreIndic.Margin = new System.Windows.Forms.Padding(4);
            this.tb_contreIndic.Name = "tb_contreIndic";
            this.tb_contreIndic.Size = new System.Drawing.Size(287, 77);
            this.tb_contreIndic.TabIndex = 6;
            this.tb_contreIndic.Text = "";
            // 
            // tb_effets
            // 
            this.tb_effets.Location = new System.Drawing.Point(146, 234);
            this.tb_effets.Margin = new System.Windows.Forms.Padding(4);
            this.tb_effets.Name = "tb_effets";
            this.tb_effets.Size = new System.Drawing.Size(344, 68);
            this.tb_effets.TabIndex = 5;
            this.tb_effets.Text = "";
            // 
            // cb_famille
            // 
            this.cb_famille.DisplayMember = "FAM_LIBELLE";
            this.cb_famille.FormattingEnabled = true;
            this.cb_famille.Location = new System.Drawing.Point(106, 149);
            this.cb_famille.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_famille.Name = "cb_famille";
            this.cb_famille.Size = new System.Drawing.Size(401, 24);
            this.cb_famille.TabIndex = 3;
            this.cb_famille.ValueMember = "FAM_LIBELLE";
            // 
            // lbl_Famille
            // 
            this.lbl_Famille.AutoSize = true;
            this.lbl_Famille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Famille.Location = new System.Drawing.Point(21, 146);
            this.lbl_Famille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Famille.Name = "lbl_Famille";
            this.lbl_Famille.Size = new System.Drawing.Size(74, 25);
            this.lbl_Famille.TabIndex = 104;
            this.lbl_Famille.Text = "Famille";
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Annuler.Location = new System.Drawing.Point(74, 431);
            this.bt_Annuler.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(128, 47);
            this.bt_Annuler.TabIndex = 7;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // bt_Valider
            // 
            this.bt_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Valider.Location = new System.Drawing.Point(294, 431);
            this.bt_Valider.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(128, 47);
            this.bt_Valider.TabIndex = 8;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = true;
            this.bt_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(216, 107);
            this.tb_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Nom.MaxLength = 15;
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(199, 22);
            this.tb_Nom.TabIndex = 2;
            // 
            // tb_Matricule
            // 
            this.tb_Matricule.Location = new System.Drawing.Point(313, 68);
            this.tb_Matricule.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Matricule.MaxLength = 10;
            this.tb_Matricule.Name = "tb_Matricule";
            this.tb_Matricule.Size = new System.Drawing.Size(97, 22);
            this.tb_Matricule.TabIndex = 1;
            // 
            // lbl_contreIndic
            // 
            this.lbl_contreIndic.AutoSize = true;
            this.lbl_contreIndic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contreIndic.Location = new System.Drawing.Point(21, 331);
            this.lbl_contreIndic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contreIndic.Name = "lbl_contreIndic";
            this.lbl_contreIndic.Size = new System.Drawing.Size(159, 25);
            this.lbl_contreIndic.TabIndex = 102;
            this.lbl_contreIndic.Text = "Contre Indication";
            // 
            // lbl_Effets
            // 
            this.lbl_Effets.AutoSize = true;
            this.lbl_Effets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Effets.Location = new System.Drawing.Point(25, 234);
            this.lbl_Effets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Effets.Name = "lbl_Effets";
            this.lbl_Effets.Size = new System.Drawing.Size(61, 25);
            this.lbl_Effets.TabIndex = 101;
            this.lbl_Effets.Text = "Effets";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.Location = new System.Drawing.Point(22, 106);
            this.lbl_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(53, 25);
            this.lbl_Nom.TabIndex = 100;
            this.lbl_Nom.Text = "Nom";
            // 
            // lbl_Matricule
            // 
            this.lbl_Matricule.AutoSize = true;
            this.lbl_Matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricule.Location = new System.Drawing.Point(21, 68);
            this.lbl_Matricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Matricule.Name = "lbl_Matricule";
            this.lbl_Matricule.Size = new System.Drawing.Size(192, 25);
            this.lbl_Matricule.TabIndex = 99;
            this.lbl_Matricule.Text = "Numéro médicament";
            // 
            // lbl_AjoutMedicament
            // 
            this.lbl_AjoutMedicament.AutoSize = true;
            this.lbl_AjoutMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AjoutMedicament.Location = new System.Drawing.Point(108, 16);
            this.lbl_AjoutMedicament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AjoutMedicament.Name = "lbl_AjoutMedicament";
            this.lbl_AjoutMedicament.Size = new System.Drawing.Size(312, 31);
            this.lbl_AjoutMedicament.TabIndex = 98;
            this.lbl_AjoutMedicament.Text = "Ajouter un médicament";
            // 
            // Form_Medicament_Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 494);
            this.Controls.Add(this.tb_Compo);
            this.Controls.Add(this.lblComposition);
            this.Controls.Add(this.tb_contreIndic);
            this.Controls.Add(this.tb_effets);
            this.Controls.Add(this.cb_famille);
            this.Controls.Add(this.lbl_Famille);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.bt_Valider);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Matricule);
            this.Controls.Add(this.lbl_contreIndic);
            this.Controls.Add(this.lbl_Effets);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.lbl_Matricule);
            this.Controls.Add(this.lbl_AjoutMedicament);
            this.Name = "Form_Medicament_Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout de médicament";
            this.Load += new System.EventHandler(this.Form_Medicament_Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Compo;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.RichTextBox tb_contreIndic;
        private System.Windows.Forms.RichTextBox tb_effets;
        private System.Windows.Forms.ComboBox cb_famille;
        private System.Windows.Forms.Label lbl_Famille;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.TextBox tb_Matricule;
        private System.Windows.Forms.Label lbl_contreIndic;
        private System.Windows.Forms.Label lbl_Effets;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Matricule;
        private System.Windows.Forms.Label lbl_AjoutMedicament;
    }
}