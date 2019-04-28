namespace PPE3_GSB_WF
{
    partial class Form_Rapports_Visiteur
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_CR = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dateVisite = new System.Windows.Forms.TextBox();
            this.tb_dateSaisie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_prac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMedicamentPremier = new System.Windows.Forms.DataGridView();
            this.nomMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_motif = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_bilan = new System.Windows.Forms.TextBox();
            this.bt_valid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_annee = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_mois = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_jour = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentPremier)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(358, 280);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 1;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(10, 19);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(44, 21);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(172, 19);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(66, 21);
            this.labelPrenom.TabIndex = 3;
            this.labelPrenom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Page des rapports de ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voir les rapports existants";
            // 
            // cb_CR
            // 
            this.cb_CR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CR.Enabled = false;
            this.cb_CR.FormattingEnabled = true;
            this.cb_CR.Location = new System.Drawing.Point(12, 363);
            this.cb_CR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_CR.Name = "cb_CR";
            this.cb_CR.Size = new System.Drawing.Size(204, 24);
            this.cb_CR.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Les rapports sont identifiés ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = " par la date de saisie";
            // 
            // tb_num
            // 
            this.tb_num.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num.Location = new System.Drawing.Point(61, 104);
            this.tb_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_num.Name = "tb_num";
            this.tb_num.ReadOnly = true;
            this.tb_num.Size = new System.Drawing.Size(47, 29);
            this.tb_num.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numéro du rapport";
            // 
            // tb_dateVisite
            // 
            this.tb_dateVisite.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dateVisite.Location = new System.Drawing.Point(302, 104);
            this.tb_dateVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dateVisite.Name = "tb_dateVisite";
            this.tb_dateVisite.ReadOnly = true;
            this.tb_dateVisite.Size = new System.Drawing.Size(116, 29);
            this.tb_dateVisite.TabIndex = 2;
            // 
            // tb_dateSaisie
            // 
            this.tb_dateSaisie.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dateSaisie.Location = new System.Drawing.Point(526, 104);
            this.tb_dateSaisie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dateSaisie.Name = "tb_dateSaisie";
            this.tb_dateSaisie.ReadOnly = true;
            this.tb_dateSaisie.Size = new System.Drawing.Size(106, 29);
            this.tb_dateSaisie.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date de la visite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date de saisie de ce rapport";
            // 
            // tb_prac
            // 
            this.tb_prac.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prac.Location = new System.Drawing.Point(223, 172);
            this.tb_prac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_prac.Name = "tb_prac";
            this.tb_prac.ReadOnly = true;
            this.tb_prac.Size = new System.Drawing.Size(141, 29);
            this.tb_prac.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Practicien visité :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tb_motif);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_bilan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_prac);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_dateSaisie);
            this.groupBox1.Controls.Add(this.tb_dateVisite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_num);
            this.groupBox1.Controls.Add(this.labelPrenom);
            this.groupBox1.Controls.Add(this.labelNom);
            this.groupBox1.Location = new System.Drawing.Point(257, -8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(912, 597);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dgvMedicamentPremier);
            this.groupBox2.Controls.Add(this.btn_Quitter);
            this.groupBox2.Location = new System.Drawing.Point(389, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(523, 336);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Médicaments";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Echantillon(s) offert(s)";
            // 
            // dgvMedicamentPremier
            // 
            this.dgvMedicamentPremier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentPremier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomMedic,
            this.nombre});
            this.dgvMedicamentPremier.Location = new System.Drawing.Point(57, 69);
            this.dgvMedicamentPremier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicamentPremier.Name = "dgvMedicamentPremier";
            this.dgvMedicamentPremier.RowTemplate.Height = 24;
            this.dgvMedicamentPremier.Size = new System.Drawing.Size(388, 190);
            this.dgvMedicamentPremier.TabIndex = 15;
            // 
            // nomMedic
            // 
            this.nomMedic.HeaderText = "Nom du médicament";
            this.nomMedic.Name = "nomMedic";
            this.nomMedic.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Quantité offerte";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // tb_motif
            // 
            this.tb_motif.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_motif.Location = new System.Drawing.Point(646, 172);
            this.tb_motif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_motif.Name = "tb_motif";
            this.tb_motif.ReadOnly = true;
            this.tb_motif.Size = new System.Drawing.Size(240, 28);
            this.tb_motif.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(473, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Motif de la visite :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bilan ";
            // 
            // tb_bilan
            // 
            this.tb_bilan.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bilan.Location = new System.Drawing.Point(3, 265);
            this.tb_bilan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_bilan.Multiline = true;
            this.tb_bilan.Name = "tb_bilan";
            this.tb_bilan.ReadOnly = true;
            this.tb_bilan.Size = new System.Drawing.Size(368, 260);
            this.tb_bilan.TabIndex = 8;
            // 
            // bt_valid
            // 
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.Location = new System.Drawing.Point(40, 403);
            this.bt_valid.Margin = new System.Windows.Forms.Padding(4);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(139, 36);
            this.bt_valid.TabIndex = 11;
            this.bt_valid.Text = "Valider";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.Bt_valid_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Créer un nouveau rapport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cb_annee
            // 
            this.cb_annee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_annee.FormattingEnabled = true;
            this.cb_annee.Location = new System.Drawing.Point(30, 158);
            this.cb_annee.Name = "cb_annee";
            this.cb_annee.Size = new System.Drawing.Size(145, 24);
            this.cb_annee.TabIndex = 13;
            this.cb_annee.SelectedIndexChanged += new System.EventHandler(this.cb_annee_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Sélectionner l\'année";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "Sélectionner le mois";
            // 
            // cb_mois
            // 
            this.cb_mois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mois.Enabled = false;
            this.cb_mois.FormattingEnabled = true;
            this.cb_mois.Location = new System.Drawing.Point(30, 226);
            this.cb_mois.Name = "cb_mois";
            this.cb_mois.Size = new System.Drawing.Size(145, 24);
            this.cb_mois.TabIndex = 15;
            this.cb_mois.SelectedIndexChanged += new System.EventHandler(this.cb_mois_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "Sélectionner le compte-rendu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 23);
            this.label15.TabIndex = 19;
            this.label15.Text = "Sélectionner le jour";
            // 
            // cb_jour
            // 
            this.cb_jour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_jour.Enabled = false;
            this.cb_jour.FormattingEnabled = true;
            this.cb_jour.Location = new System.Drawing.Point(29, 292);
            this.cb_jour.Name = "cb_jour";
            this.cb_jour.Size = new System.Drawing.Size(145, 24);
            this.cb_jour.TabIndex = 18;
            this.cb_jour.SelectedIndexChanged += new System.EventHandler(this.cb_jour_SelectedIndexChanged);
            // 
            // Form_Rapports_Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 590);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cb_jour);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_mois);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_annee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_valid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_CR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Rapports_Visiteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapports";
            this.Load += new System.EventHandler(this.Form_Rapports_Visiteur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentPremier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        public System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_CR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dateVisite;
        private System.Windows.Forms.TextBox tb_dateSaisie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_prac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMedicamentPremier;
        private System.Windows.Forms.TextBox tb_motif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_bilan;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_annee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_mois;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_jour;
    }
}