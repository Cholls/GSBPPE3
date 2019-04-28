namespace PPE3_GSB_WF
{
    partial class Form_Medicaments
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
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.lbl_lstVisiteurs = new System.Windows.Forms.Label();
            this.bt_valid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_contre = new System.Windows.Forms.TextBox();
            this.tb_effet = new System.Windows.Forms.TextBox();
            this.tb_compo = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_famille = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_famille = new System.Windows.Forms.ComboBox();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_valid = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nb = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(12, 528);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 2;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // lbl_lstVisiteurs
            // 
            this.lbl_lstVisiteurs.AutoSize = true;
            this.lbl_lstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstVisiteurs.Location = new System.Drawing.Point(6, 9);
            this.lbl_lstVisiteurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstVisiteurs.Name = "lbl_lstVisiteurs";
            this.lbl_lstVisiteurs.Size = new System.Drawing.Size(366, 31);
            this.lbl_lstVisiteurs.TabIndex = 7;
            this.lbl_lstVisiteurs.Text = " Consultation Médicaments";
            // 
            // bt_valid
            // 
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.Location = new System.Drawing.Point(103, 207);
            this.bt_valid.Margin = new System.Windows.Forms.Padding(4);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(139, 47);
            this.bt_valid.TabIndex = 44;
            this.bt_valid.Text = "Valider";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.bt_valid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Choisir un médicament parmi la liste";
            // 
            // cb_select
            // 
            this.cb_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(58, 165);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(237, 24);
            this.cb_select.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Contre-indication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(803, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "Effet(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Composition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nom du médicament";
            // 
            // tb_contre
            // 
            this.tb_contre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contre.Location = new System.Drawing.Point(522, 266);
            this.tb_contre.Multiline = true;
            this.tb_contre.Name = "tb_contre";
            this.tb_contre.ReadOnly = true;
            this.tb_contre.Size = new System.Drawing.Size(217, 191);
            this.tb_contre.TabIndex = 64;
            // 
            // tb_effet
            // 
            this.tb_effet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_effet.Location = new System.Drawing.Point(807, 266);
            this.tb_effet.Multiline = true;
            this.tb_effet.Name = "tb_effet";
            this.tb_effet.ReadOnly = true;
            this.tb_effet.Size = new System.Drawing.Size(286, 191);
            this.tb_effet.TabIndex = 63;
            // 
            // tb_compo
            // 
            this.tb_compo.Location = new System.Drawing.Point(680, 138);
            this.tb_compo.Multiline = true;
            this.tb_compo.Name = "tb_compo";
            this.tb_compo.ReadOnly = true;
            this.tb_compo.Size = new System.Drawing.Size(295, 51);
            this.tb_compo.TabIndex = 62;
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.Location = new System.Drawing.Point(456, 154);
            this.tb_nom.MaxLength = 30;
            this.tb_nom.Multiline = true;
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(183, 29);
            this.tb_nom.TabIndex = 60;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouter.Location = new System.Drawing.Point(202, 528);
            this.bt_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(139, 47);
            this.bt_ajouter.TabIndex = 70;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1006, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Famille";
            // 
            // tb_famille
            // 
            this.tb_famille.Location = new System.Drawing.Point(1010, 138);
            this.tb_famille.MaxLength = 30;
            this.tb_famille.Name = "tb_famille";
            this.tb_famille.ReadOnly = true;
            this.tb_famille.Size = new System.Drawing.Size(137, 22);
            this.tb_famille.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Choisir une famille";
            // 
            // cb_famille
            // 
            this.cb_famille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_famille.FormattingEnabled = true;
            this.cb_famille.Location = new System.Drawing.Point(11, 74);
            this.cb_famille.Name = "cb_famille";
            this.cb_famille.Size = new System.Drawing.Size(471, 24);
            this.cb_famille.TabIndex = 74;
            this.cb_famille.SelectedIndexChanged += new System.EventHandler(this.cb_famille_SelectedIndexChanged);
            // 
            // btn_suppr
            // 
            this.btn_suppr.Enabled = false;
            this.btn_suppr.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppr.Location = new System.Drawing.Point(878, 529);
            this.btn_suppr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(255, 48);
            this.btn_suppr.TabIndex = 81;
            this.btn_suppr.Text = "Supprimer";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(569, 530);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 47);
            this.button2.TabIndex = 80;
            this.button2.Text = "Valider les modifications";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_valid);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_recherche);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 136);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche par nom";
            // 
            // but_valid
            // 
            this.but_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_valid.Location = new System.Drawing.Point(219, 83);
            this.but_valid.Margin = new System.Windows.Forms.Padding(4);
            this.but_valid.Name = "but_valid";
            this.but_valid.Size = new System.Drawing.Size(110, 34);
            this.but_valid.TabIndex = 63;
            this.but_valid.Text = "Valider";
            this.but_valid.UseVisualStyleBackColor = true;
            this.but_valid.Click += new System.EventHandler(this.but_valid_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tapez le nom recherché puis validez";
            // 
            // tb_recherche
            // 
            this.tb_recherche.Location = new System.Drawing.Point(23, 89);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(168, 28);
            this.tb_recherche.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(373, 23);
            this.label11.TabIndex = 41;
            this.label11.Text = "Vous cherchez un médicament en particulier ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 23);
            this.label8.TabIndex = 83;
            this.label8.Text = "Nombre de médicaments enregistrés :";
            // 
            // tb_nb
            // 
            this.tb_nb.Location = new System.Drawing.Point(854, 8);
            this.tb_nb.Name = "tb_nb";
            this.tb_nb.ReadOnly = true;
            this.tb_nb.Size = new System.Drawing.Size(60, 22);
            this.tb_nb.TabIndex = 84;
            // 
            // Form_Medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 590);
            this.Controls.Add(this.tb_nb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_famille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_famille);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_contre);
            this.Controls.Add(this.tb_effet);
            this.Controls.Add(this.tb_compo);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.bt_valid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_select);
            this.Controls.Add(this.lbl_lstVisiteurs);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Medicaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicaments";
            this.Load += new System.EventHandler(this.Form_Medicaments_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        
        private System.Windows.Forms.Label lbl_lstVisiteurs;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_contre;
        private System.Windows.Forms.TextBox tb_effet;
        private System.Windows.Forms.TextBox tb_compo;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_famille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_famille;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_valid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nb;
    }
}