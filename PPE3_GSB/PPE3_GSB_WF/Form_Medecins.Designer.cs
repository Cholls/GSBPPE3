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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_choixMedecins = new System.Windows.Forms.Label();
            this.lbl_lstMedecins = new System.Windows.Forms.Label();
            this.cb_Medecins = new System.Windows.Forms.ComboBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.grid_Medecins = new System.Windows.Forms.DataGridView();
            this.btn_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medecins)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(380, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 434);
            this.panel1.TabIndex = 26;
            // 
            // lbl_choixMedecins
            // 
            this.lbl_choixMedecins.AutoSize = true;
            this.lbl_choixMedecins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choixMedecins.Location = new System.Drawing.Point(502, 135);
            this.lbl_choixMedecins.Name = "lbl_choixMedecins";
            this.lbl_choixMedecins.Size = new System.Drawing.Size(157, 16);
            this.lbl_choixMedecins.TabIndex = 25;
            this.lbl_choixMedecins.Text = "Séléctionnez un médecin";
            // 
            // lbl_lstMedecins
            // 
            this.lbl_lstMedecins.AutoSize = true;
            this.lbl_lstMedecins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstMedecins.Location = new System.Drawing.Point(95, 17);
            this.lbl_lstMedecins.Name = "lbl_lstMedecins";
            this.lbl_lstMedecins.Size = new System.Drawing.Size(215, 25);
            this.lbl_lstMedecins.TabIndex = 24;
            this.lbl_lstMedecins.Text = "Liste des médecins";
            // 
            // cb_Medecins
            // 
            this.cb_Medecins.FormattingEnabled = true;
            this.cb_Medecins.Location = new System.Drawing.Point(486, 164);
            this.cb_Medecins.Name = "cb_Medecins";
            this.cb_Medecins.Size = new System.Drawing.Size(190, 21);
            this.cb_Medecins.TabIndex = 23;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.Location = new System.Drawing.Point(590, 206);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(82, 23);
            this.btn_Supprimer.TabIndex = 22;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.Location = new System.Drawing.Point(490, 206);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(82, 23);
            this.btn_Modifier.TabIndex = 21;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(155, 393);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 20;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // grid_Medecins
            // 
            this.grid_Medecins.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_Medecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Medecins.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid_Medecins.Location = new System.Drawing.Point(49, 47);
            this.grid_Medecins.Name = "grid_Medecins";
            this.grid_Medecins.Size = new System.Drawing.Size(289, 337);
            this.grid_Medecins.TabIndex = 19;
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(529, 353);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(104, 39);
            this.btn_Quitter.TabIndex = 18;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // Form_Medecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_choixMedecins);
            this.Controls.Add(this.lbl_lstMedecins);
            this.Controls.Add(this.cb_Medecins);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.grid_Medecins);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Medecins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medecins";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medecins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_choixMedecins;
        private System.Windows.Forms.Label lbl_lstMedecins;
        private System.Windows.Forms.ComboBox cb_Medecins;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.DataGridView grid_Medecins;
        private System.Windows.Forms.Button btn_Quitter;
    }
}