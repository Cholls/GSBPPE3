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
            this.cb_select = new System.Windows.Forms.ComboBox();
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
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbechant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_motif = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_bilan = new System.Windows.Forms.TextBox();
            this.bt_valid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(12, 462);
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
            this.labelNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(253, 1);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(50, 24);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(410, 1);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(76, 24);
            this.labelPrenom.TabIndex = 3;
            this.labelPrenom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Page des rapports de ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voir les rapports existants";
            // 
            // cb_select
            // 
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(12, 145);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(197, 24);
            this.cb_select.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Les rapports sont identifiés ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = " par la date de saisie";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(20, 51);
            this.tb_num.Name = "tb_num";
            this.tb_num.ReadOnly = true;
            this.tb_num.Size = new System.Drawing.Size(39, 22);
            this.tb_num.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numéro du rapport";
            // 
            // tb_dateVisite
            // 
            this.tb_dateVisite.Location = new System.Drawing.Point(261, 51);
            this.tb_dateVisite.Name = "tb_dateVisite";
            this.tb_dateVisite.ReadOnly = true;
            this.tb_dateVisite.Size = new System.Drawing.Size(87, 22);
            this.tb_dateVisite.TabIndex = 2;
            // 
            // tb_dateSaisie
            // 
            this.tb_dateSaisie.Location = new System.Drawing.Point(486, 51);
            this.tb_dateSaisie.Name = "tb_dateSaisie";
            this.tb_dateSaisie.ReadOnly = true;
            this.tb_dateSaisie.Size = new System.Drawing.Size(85, 22);
            this.tb_dateSaisie.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date de la visite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date de saisie de ce rapport";
            // 
            // tb_prac
            // 
            this.tb_prac.Location = new System.Drawing.Point(148, 106);
            this.tb_prac.Name = "tb_prac";
            this.tb_prac.ReadOnly = true;
            this.tb_prac.Size = new System.Drawing.Size(141, 22);
            this.tb_prac.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 106);
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
            this.groupBox1.Location = new System.Drawing.Point(257, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 469);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualisation du rapport sélectionné";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMedicament);
            this.groupBox2.Location = new System.Drawing.Point(352, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 285);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Médicaments";
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricule,
            this.medic,
            this.nbechant});
            this.dgvMedicament.Location = new System.Drawing.Point(6, 53);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.RowTemplate.Height = 24;
            this.dgvMedicament.Size = new System.Drawing.Size(388, 150);
            this.dgvMedicament.TabIndex = 15;
            // 
            // matricule
            // 
            this.matricule.HeaderText = "Dépot légal";
            this.matricule.Name = "matricule";
            // 
            // medic
            // 
            this.medic.HeaderText = "Nom du médicament";
            this.medic.Name = "medic";
            // 
            // nbechant
            // 
            this.nbechant.HeaderText = "Nombre d\'échantillon";
            this.nbechant.Name = "nbechant";
            // 
            // tb_motif
            // 
            this.tb_motif.Location = new System.Drawing.Point(512, 107);
            this.tb_motif.Name = "tb_motif";
            this.tb_motif.ReadOnly = true;
            this.tb_motif.Size = new System.Drawing.Size(240, 22);
            this.tb_motif.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Motif de la visite :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bilan ";
            // 
            // tb_bilan
            // 
            this.tb_bilan.Location = new System.Drawing.Point(6, 184);
            this.tb_bilan.Multiline = true;
            this.tb_bilan.Name = "tb_bilan";
            this.tb_bilan.ReadOnly = true;
            this.tb_bilan.Size = new System.Drawing.Size(321, 70);
            this.tb_bilan.TabIndex = 8;
            // 
            // bt_valid
            // 
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.Location = new System.Drawing.Point(31, 176);
            this.bt_valid.Margin = new System.Windows.Forms.Padding(4);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(139, 48);
            this.bt_valid.TabIndex = 11;
            this.bt_valid.Text = "Valider";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.Bt_valid_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 79);
            this.button1.TabIndex = 12;
            this.button1.Text = "Créer un nouveau rapport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Rapports_Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_valid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Rapports_Visiteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapports";
            this.Load += new System.EventHandler(this.Form_Rapports_Visiteur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        public System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_select;
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
        private System.Windows.Forms.DataGridView dgvMedicament;
        private System.Windows.Forms.TextBox tb_motif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_bilan;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn medic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbechant;
        private System.Windows.Forms.Button button1;
    }
}