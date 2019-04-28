namespace PPE3_GSB_WF.UI
{
    partial class Form_Rapport_Ajouter
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomVis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bilan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateVisitePick = new System.Windows.Forms.DateTimePicker();
            this.bt_valid = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_motif = new System.Windows.Forms.ComboBox();
            this.cb_praticien = new System.Windows.Forms.ComboBox();
            this.cb_praticienBis = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.med1 = new System.Windows.Forms.Panel();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_qt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this.nomMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMed = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.med1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            this.panelMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'un nouveau rapport ";
            // 
            // tb_nomVis
            // 
            this.tb_nomVis.Location = new System.Drawing.Point(778, 6);
            this.tb_nomVis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nomVis.Name = "tb_nomVis";
            this.tb_nomVis.ReadOnly = true;
            this.tb_nomVis.Size = new System.Drawing.Size(72, 22);
            this.tb_nomVis.TabIndex = 1;
            this.tb_nomVis.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Praticien visité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom du praticien remplaçant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date de visite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bilan";
            // 
            // tb_bilan
            // 
            this.tb_bilan.Location = new System.Drawing.Point(459, 135);
            this.tb_bilan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_bilan.MaxLength = 255;
            this.tb_bilan.Multiline = true;
            this.tb_bilan.Name = "tb_bilan";
            this.tb_bilan.Size = new System.Drawing.Size(391, 91);
            this.tb_bilan.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Motif de la visite";
            // 
            // dateVisitePick
            // 
            this.dateVisitePick.Location = new System.Drawing.Point(145, 110);
            this.dateVisitePick.Margin = new System.Windows.Forms.Padding(4);
            this.dateVisitePick.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateVisitePick.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateVisitePick.Name = "dateVisitePick";
            this.dateVisitePick.Size = new System.Drawing.Size(265, 22);
            this.dateVisitePick.TabIndex = 3;
            // 
            // bt_valid
            // 
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.Location = new System.Drawing.Point(252, 256);
            this.bt_valid.Margin = new System.Windows.Forms.Padding(4);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(406, 48);
            this.bt_valid.TabIndex = 23;
            this.bt_valid.Text = "Valider le nouveau compte-rendu";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.bt_valid_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(455, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "(Facultatif)";
            // 
            // cb_motif
            // 
            this.cb_motif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_motif.FormattingEnabled = true;
            this.cb_motif.Location = new System.Drawing.Point(145, 159);
            this.cb_motif.Name = "cb_motif";
            this.cb_motif.Size = new System.Drawing.Size(265, 24);
            this.cb_motif.TabIndex = 4;
            // 
            // cb_praticien
            // 
            this.cb_praticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_praticien.FormattingEnabled = true;
            this.cb_praticien.Location = new System.Drawing.Point(145, 61);
            this.cb_praticien.Name = "cb_praticien";
            this.cb_praticien.Size = new System.Drawing.Size(226, 24);
            this.cb_praticien.TabIndex = 1;
            // 
            // cb_praticienBis
            // 
            this.cb_praticienBis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_praticienBis.FormattingEnabled = true;
            this.cb_praticienBis.Location = new System.Drawing.Point(701, 55);
            this.cb_praticienBis.Name = "cb_praticienBis";
            this.cb_praticienBis.Size = new System.Drawing.Size(211, 24);
            this.cb_praticienBis.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.med1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 208);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Echantillons de médicaments";
            // 
            // med1
            // 
            this.med1.Controls.Add(this.cb_select);
            this.med1.Controls.Add(this.label12);
            this.med1.Controls.Add(this.label13);
            this.med1.Controls.Add(this.tb_qt);
            this.med1.Location = new System.Drawing.Point(0, 87);
            this.med1.Name = "med1";
            this.med1.Size = new System.Drawing.Size(599, 40);
            this.med1.TabIndex = 38;
            // 
            // cb_select
            // 
            this.cb_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(178, 9);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(212, 24);
            this.cb_select.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nom du médicament";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Quantité";
            // 
            // tb_qt
            // 
            this.tb_qt.Location = new System.Drawing.Point(479, 11);
            this.tb_qt.MaxLength = 3;
            this.tb_qt.Name = "tb_qt";
            this.tb_qt.Size = new System.Drawing.Size(91, 22);
            this.tb_qt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Pour ce faire, il faut cliquer à nouveau sur \"Ajouter un échantillon\".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Information : Vous pouvez en ajouter plusieurs. ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ajouter un échantillon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomMedic,
            this.nombre});
            this.dgvMedicament.Location = new System.Drawing.Point(611, 33);
            this.dgvMedicament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.RowTemplate.Height = 24;
            this.dgvMedicament.Size = new System.Drawing.Size(306, 203);
            this.dgvMedicament.TabIndex = 35;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Visualisation des échantillons";
            // 
            // panelMed
            // 
            this.panelMed.Controls.Add(this.groupBox1);
            this.panelMed.Controls.Add(this.dgvMedicament);
            this.panelMed.Controls.Add(this.label7);
            this.panelMed.Location = new System.Drawing.Point(2, 374);
            this.panelMed.Name = "panelMed";
            this.panelMed.Size = new System.Drawing.Size(928, 253);
            this.panelMed.TabIndex = 38;
            this.panelMed.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(517, 21);
            this.label11.TabIndex = 37;
            this.label11.Text = "Vous devez d\'abord créer le compte-rendu avant d\'y lier des échantillons.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(562, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 21);
            this.label14.TabIndex = 39;
            this.label14.Text = "Cette option est facultative.";
            // 
            // Form_Rapport_Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 639);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelMed);
            this.Controls.Add(this.cb_praticienBis);
            this.Controls.Add(this.cb_praticien);
            this.Controls.Add(this.cb_motif);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_valid);
            this.Controls.Add(this.dateVisitePick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_bilan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nomVis);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Rapport_Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un rapport";
            this.Load += new System.EventHandler(this.Form_Rapport_Ajouter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.med1.ResumeLayout(false);
            this.med1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            this.panelMed.ResumeLayout(false);
            this.panelMed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_bilan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateVisitePick;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tb_nomVis;
        private System.Windows.Forms.ComboBox cb_motif;
        private System.Windows.Forms.ComboBox cb_praticien;
        private System.Windows.Forms.ComboBox cb_praticienBis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel med1;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_qt;
        private System.Windows.Forms.Label label14;
    }
}