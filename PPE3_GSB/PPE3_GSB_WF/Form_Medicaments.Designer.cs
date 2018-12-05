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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gSB_PPE3DataSet5 = new PPE3_GSB_WF.GSB_PPE3DataSet5();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentTableAdapter = new PPE3_GSB_WF.GSB_PPE3DataSet5TableAdapters.medicamentTableAdapter();
            this.medicamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_lstVisiteurs = new System.Windows.Forms.Label();
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDEFFETSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(841, 462);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 2;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn,
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn,
            this.mEDEFFETSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 443);
            this.dataGridView1.TabIndex = 3;
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
            // medicamentBindingSource1
            // 
            this.medicamentBindingSource1.DataMember = "medicament";
            this.medicamentBindingSource1.DataSource = this.gSB_PPE3DataSet5;
            // 
            // lbl_lstVisiteurs
            // 
            this.lbl_lstVisiteurs.AutoSize = true;
            this.lbl_lstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstVisiteurs.Location = new System.Drawing.Point(224, 9);
            this.lbl_lstVisiteurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstVisiteurs.Name = "lbl_lstVisiteurs";
            this.lbl_lstVisiteurs.Size = new System.Drawing.Size(312, 31);
            this.lbl_lstVisiteurs.TabIndex = 7;
            this.lbl_lstVisiteurs.Text = "Liste des médicaments";
            // 
            // mEDNOMCOMMERCIALDataGridViewTextBoxColumn
            // 
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.DataPropertyName = "MED_NOMCOMMERCIAL";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.HeaderText = "Nom du médicament";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.Name = "mEDNOMCOMMERCIALDataGridViewTextBoxColumn";
            // 
            // mEDCOMPOSITIONDataGridViewTextBoxColumn
            // 
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "MED_COMPOSITION";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.HeaderText = "Composition";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.Name = "mEDCOMPOSITIONDataGridViewTextBoxColumn";
            // 
            // mEDEFFETSDataGridViewTextBoxColumn
            // 
            this.mEDEFFETSDataGridViewTextBoxColumn.DataPropertyName = "MED_EFFETS";
            this.mEDEFFETSDataGridViewTextBoxColumn.HeaderText = "Effet(s)";
            this.mEDEFFETSDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.mEDEFFETSDataGridViewTextBoxColumn.Name = "mEDEFFETSDataGridViewTextBoxColumn";
            this.mEDEFFETSDataGridViewTextBoxColumn.Width = 1000;
            // 
            // Form_Medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 523);
            this.Controls.Add(this.lbl_lstVisiteurs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Medicaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicaments";
            this.Load += new System.EventHandler(this.Form_Medicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GSB_PPE3DataSet5 gSB_PPE3DataSet5;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private GSB_PPE3DataSet5TableAdapters.medicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.BindingSource medicamentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDNOMCOMMERCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDCOMPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDEFFETSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_lstVisiteurs;
    }
}