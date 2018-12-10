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
            this.components = new System.ComponentModel.Container();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.medicamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet5 = new PPE3_GSB_WF.GSB_PPE3DataSet5();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentTableAdapter = new PPE3_GSB_WF.GSB_PPE3DataSet5TableAdapters.medicamentTableAdapter();
            this.lbl_lstVisiteurs = new System.Windows.Forms.Label();
            this.bt_valid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_contre = new System.Windows.Forms.TextBox();
            this.tb_effet = new System.Windows.Forms.TextBox();
            this.tb_compo = new System.Windows.Forms.TextBox();
            this.tb_depot = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(28, 447);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 2;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // medicamentBindingSource1
            // 
            this.medicamentBindingSource1.DataMember = "medicament";
            this.medicamentBindingSource1.DataSource = this.gSB_PPE3DataSet5;
            // 
            // gSB_PPE3DataSet5
            // 
            this.gSB_PPE3DataSet5.DataSetName = "GSB_PPE3DataSet5";
            this.gSB_PPE3DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "medicament";
            this.medicamentBindingSource.DataSource = this.gSB_PPE3DataSet5;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_lstVisiteurs
            // 
            this.lbl_lstVisiteurs.AutoSize = true;
            this.lbl_lstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstVisiteurs.Location = new System.Drawing.Point(22, 21);
            this.lbl_lstVisiteurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstVisiteurs.Name = "lbl_lstVisiteurs";
            this.lbl_lstVisiteurs.Size = new System.Drawing.Size(477, 31);
            this.lbl_lstVisiteurs.TabIndex = 7;
            this.lbl_lstVisiteurs.Text = " Consultation fiche de médicaments";
            // 
            // bt_valid
            // 
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.Location = new System.Drawing.Point(111, 189);
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
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Choisir un médicament parmi la liste";
            // 
            // cb_select
            // 
            this.cb_select.DataSource = this.medicamentBindingSource1;
            this.cb_select.DisplayMember = "MED_NOMCOMMERCIAL";
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(65, 147);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(237, 24);
            this.cb_select.TabIndex = 42;
            this.cb_select.ValueMember = "MED_NOMCOMMERCIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Contre-indication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(708, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "Effet(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Composition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Dépot légal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nom du médicament";
            // 
            // tb_contre
            // 
            this.tb_contre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contre.Location = new System.Drawing.Point(356, 276);
            this.tb_contre.Multiline = true;
            this.tb_contre.Name = "tb_contre";
            this.tb_contre.ReadOnly = true;
            this.tb_contre.Size = new System.Drawing.Size(299, 191);
            this.tb_contre.TabIndex = 64;
            // 
            // tb_effet
            // 
            this.tb_effet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_effet.Location = new System.Drawing.Point(712, 276);
            this.tb_effet.Multiline = true;
            this.tb_effet.Name = "tb_effet";
            this.tb_effet.ReadOnly = true;
            this.tb_effet.Size = new System.Drawing.Size(286, 191);
            this.tb_effet.TabIndex = 63;
            // 
            // tb_compo
            // 
            this.tb_compo.Location = new System.Drawing.Point(615, 147);
            this.tb_compo.Multiline = true;
            this.tb_compo.Name = "tb_compo";
            this.tb_compo.ReadOnly = true;
            this.tb_compo.Size = new System.Drawing.Size(295, 51);
            this.tb_compo.TabIndex = 62;
            // 
            // tb_depot
            // 
            this.tb_depot.Location = new System.Drawing.Point(425, 167);
            this.tb_depot.MaxLength = 30;
            this.tb_depot.Name = "tb_depot";
            this.tb_depot.ReadOnly = true;
            this.tb_depot.Size = new System.Drawing.Size(137, 22);
            this.tb_depot.TabIndex = 61;
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.Location = new System.Drawing.Point(568, 47);
            this.tb_nom.MaxLength = 30;
            this.tb_nom.Multiline = true;
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(166, 29);
            this.tb_nom.TabIndex = 60;
            // 
            // Form_Medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 523);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_contre);
            this.Controls.Add(this.tb_effet);
            this.Controls.Add(this.tb_compo);
            this.Controls.Add(this.tb_depot);
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
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        private GSB_PPE3DataSet5 gSB_PPE3DataSet5;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private GSB_PPE3DataSet5TableAdapters.medicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.BindingSource medicamentBindingSource1;
        private System.Windows.Forms.Label lbl_lstVisiteurs;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_contre;
        private System.Windows.Forms.TextBox tb_effet;
        private System.Windows.Forms.TextBox tb_compo;
        private System.Windows.Forms.TextBox tb_depot;
        private System.Windows.Forms.TextBox tb_nom;
    }
}