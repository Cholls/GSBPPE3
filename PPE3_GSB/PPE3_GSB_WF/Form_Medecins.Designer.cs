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
            this.components = new System.ComponentModel.Container();
            this.lbl_lstMedecins = new System.Windows.Forms.Label();
            this.praticienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet2 = new PPE3_GSB_WF.GSB_PPE3DataSet2();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.grid_Medecins = new System.Windows.Forms.DataGridView();
            this.praticienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet1 = new PPE3_GSB_WF.GSB_PPE3DataSet1();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.eCOLECONDUITEDataSet = new PPE3_GSB_WF.ECOLECONDUITEDataSet();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLEVETableAdapter = new PPE3_GSB_WF.ECOLECONDUITEDataSetTableAdapters.ELEVETableAdapter();
            this.praticienTableAdapter = new PPE3_GSB_WF.GSB_PPE3DataSet1TableAdapters.praticienTableAdapter();
            this.praticienTableAdapter1 = new PPE3_GSB_WF.GSB_PPE3DataSet2TableAdapters.praticienTableAdapter();
            this.pRANOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAPRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAVILLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAADRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medecins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCOLECONDUITEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lstMedecins
            // 
            this.lbl_lstMedecins.AutoSize = true;
            this.lbl_lstMedecins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstMedecins.Location = new System.Drawing.Point(127, 21);
            this.lbl_lstMedecins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lstMedecins.Name = "lbl_lstMedecins";
            this.lbl_lstMedecins.Size = new System.Drawing.Size(264, 31);
            this.lbl_lstMedecins.TabIndex = 24;
            this.lbl_lstMedecins.Text = "Liste des médecins";
            // 
            // praticienBindingSource1
            // 
            this.praticienBindingSource1.DataMember = "praticien";
            this.praticienBindingSource1.DataSource = this.gSB_PPE3DataSet2;
            // 
            // gSB_PPE3DataSet2
            // 
            this.gSB_PPE3DataSet2.DataSetName = "GSB_PPE3DataSet2";
            this.gSB_PPE3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(207, 484);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(100, 28);
            this.btn_Ajouter.TabIndex = 20;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // grid_Medecins
            // 
            this.grid_Medecins.AutoGenerateColumns = false;
            this.grid_Medecins.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_Medecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Medecins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRANOMDataGridViewTextBoxColumn,
            this.pRAPRENOMDataGridViewTextBoxColumn,
            this.pRACPDataGridViewTextBoxColumn,
            this.pRAVILLEDataGridViewTextBoxColumn,
            this.pRAADRESSEDataGridViewTextBoxColumn});
            this.grid_Medecins.DataSource = this.praticienBindingSource;
            this.grid_Medecins.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid_Medecins.Location = new System.Drawing.Point(13, 61);
            this.grid_Medecins.Margin = new System.Windows.Forms.Padding(4);
            this.grid_Medecins.Name = "grid_Medecins";
            this.grid_Medecins.Size = new System.Drawing.Size(762, 415);
            this.grid_Medecins.TabIndex = 19;
            // 
            // praticienBindingSource
            // 
            this.praticienBindingSource.DataMember = "praticien";
            this.praticienBindingSource.DataSource = this.gSB_PPE3DataSet1;
            // 
            // gSB_PPE3DataSet1
            // 
            this.gSB_PPE3DataSet1.DataSetName = "GSB_PPE3DataSet1";
            this.gSB_PPE3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(864, 462);
            this.btn_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(139, 48);
            this.btn_Quitter.TabIndex = 18;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // eCOLECONDUITEDataSet
            // 
            this.eCOLECONDUITEDataSet.DataSetName = "ECOLECONDUITEDataSet";
            this.eCOLECONDUITEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLEVEBindingSource
            // 
            this.eLEVEBindingSource.DataMember = "ELEVE";
            this.eLEVEBindingSource.DataSource = this.eCOLECONDUITEDataSet;
            // 
            // eLEVETableAdapter
            // 
            this.eLEVETableAdapter.ClearBeforeFill = true;
            // 
            // praticienTableAdapter
            // 
            this.praticienTableAdapter.ClearBeforeFill = true;
            // 
            // praticienTableAdapter1
            // 
            this.praticienTableAdapter1.ClearBeforeFill = true;
            // 
            // pRANOMDataGridViewTextBoxColumn
            // 
            this.pRANOMDataGridViewTextBoxColumn.DataPropertyName = "PRA_NOM";
            this.pRANOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.pRANOMDataGridViewTextBoxColumn.Name = "pRANOMDataGridViewTextBoxColumn";
            // 
            // pRAPRENOMDataGridViewTextBoxColumn
            // 
            this.pRAPRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRA_PRENOM";
            this.pRAPRENOMDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.pRAPRENOMDataGridViewTextBoxColumn.Name = "pRAPRENOMDataGridViewTextBoxColumn";
            // 
            // pRACPDataGridViewTextBoxColumn
            // 
            this.pRACPDataGridViewTextBoxColumn.DataPropertyName = "PRA_CP";
            this.pRACPDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.pRACPDataGridViewTextBoxColumn.Name = "pRACPDataGridViewTextBoxColumn";
            // 
            // pRAVILLEDataGridViewTextBoxColumn
            // 
            this.pRAVILLEDataGridViewTextBoxColumn.DataPropertyName = "PRA_VILLE";
            this.pRAVILLEDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.pRAVILLEDataGridViewTextBoxColumn.Name = "pRAVILLEDataGridViewTextBoxColumn";
            // 
            // pRAADRESSEDataGridViewTextBoxColumn
            // 
            this.pRAADRESSEDataGridViewTextBoxColumn.DataPropertyName = "PRA_ADRESSE";
            this.pRAADRESSEDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.pRAADRESSEDataGridViewTextBoxColumn.Name = "pRAADRESSEDataGridViewTextBoxColumn";
            // 
            // Form_Medecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 523);
            this.Controls.Add(this.lbl_lstMedecins);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.grid_Medecins);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Medecins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medecins";
            this.Load += new System.EventHandler(this.Form_Medecins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medecins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCOLECONDUITEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_lstMedecins;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.DataGridView grid_Medecins;
        private System.Windows.Forms.Button btn_Quitter;
        private ECOLECONDUITEDataSet eCOLECONDUITEDataSet;
        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        private ECOLECONDUITEDataSetTableAdapters.ELEVETableAdapter eLEVETableAdapter;
        private GSB_PPE3DataSet1 gSB_PPE3DataSet1;
        private System.Windows.Forms.BindingSource praticienBindingSource;
        private GSB_PPE3DataSet1TableAdapters.praticienTableAdapter praticienTableAdapter;
        private GSB_PPE3DataSet2 gSB_PPE3DataSet2;
        private System.Windows.Forms.BindingSource praticienBindingSource1;
        private GSB_PPE3DataSet2TableAdapters.praticienTableAdapter praticienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRANOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAVILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAADRESSEDataGridViewTextBoxColumn;
    }
}