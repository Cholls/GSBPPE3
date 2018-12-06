namespace PPE3_GSB_WF
{
    partial class Form_Visiteurs
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
            this.grid_Visiteurs = new System.Windows.Forms.DataGridView();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.lbl_lstVisiteurs = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vISNOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISPRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISADRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISVILLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteursBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gSBPPE3DataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet4 = new PPE3_GSB_WF.GSB_PPE3DataSet4();
            this.visiteursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_PPE3DataSet = new PPE3_GSB_WF.GSB_PPE3DataSet();
            this.visiteursTableAdapter = new PPE3_GSB_WF.GSB_PPE3DataSetTableAdapters.visiteursTableAdapter();
            this.visiteursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visiteursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.visiteursTableAdapter1 = new PPE3_GSB_WF.GSB_PPE3DataSet4TableAdapters.visiteursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Visiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSBPPE3DataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(658, 328);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(104, 39);
            this.btn_Quitter.TabIndex = 0;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // grid_Visiteurs
            // 
            this.grid_Visiteurs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_Visiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Visiteurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid_Visiteurs.Location = new System.Drawing.Point(49, 47);
            this.grid_Visiteurs.Name = "grid_Visiteurs";
            this.grid_Visiteurs.Size = new System.Drawing.Size(553, 337);
            this.grid_Visiteurs.TabIndex = 1;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(660, 130);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(102, 39);
            this.btn_Ajouter.TabIndex = 2;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // lbl_lstVisiteurs
            // 
            this.lbl_lstVisiteurs.AutoSize = true;
            this.lbl_lstVisiteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lstVisiteurs.Location = new System.Drawing.Point(104, 9);
            this.lbl_lstVisiteurs.Name = "lbl_lstVisiteurs";
            this.lbl_lstVisiteurs.Size = new System.Drawing.Size(204, 25);
            this.lbl_lstVisiteurs.TabIndex = 6;
            this.lbl_lstVisiteurs.Text = "Liste des visiteurs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vISNOMDataGridViewTextBoxColumn,
            this.vISPRENOMDataGridViewTextBoxColumn,
            this.vISADRESSEDataGridViewTextBoxColumn,
            this.vISCPDataGridViewTextBoxColumn,
            this.vISVILLEDataGridViewTextBoxColumn,
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.visiteursBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 366);
            this.dataGridView1.TabIndex = 9;
            // 
            // vISNOMDataGridViewTextBoxColumn
            // 
            this.vISNOMDataGridViewTextBoxColumn.DataPropertyName = "VIS_NOM";
            this.vISNOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.vISNOMDataGridViewTextBoxColumn.Name = "vISNOMDataGridViewTextBoxColumn";
            // 
            // vISPRENOMDataGridViewTextBoxColumn
            // 
            this.vISPRENOMDataGridViewTextBoxColumn.DataPropertyName = "VIS_PRENOM";
            this.vISPRENOMDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.vISPRENOMDataGridViewTextBoxColumn.Name = "vISPRENOMDataGridViewTextBoxColumn";
            // 
            // vISADRESSEDataGridViewTextBoxColumn
            // 
            this.vISADRESSEDataGridViewTextBoxColumn.DataPropertyName = "VIS_ADRESSE";
            this.vISADRESSEDataGridViewTextBoxColumn.HeaderText = "Adrese";
            this.vISADRESSEDataGridViewTextBoxColumn.Name = "vISADRESSEDataGridViewTextBoxColumn";
            // 
            // vISCPDataGridViewTextBoxColumn
            // 
            this.vISCPDataGridViewTextBoxColumn.DataPropertyName = "VIS_CP";
            this.vISCPDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.vISCPDataGridViewTextBoxColumn.Name = "vISCPDataGridViewTextBoxColumn";
            // 
            // vISVILLEDataGridViewTextBoxColumn
            // 
            this.vISVILLEDataGridViewTextBoxColumn.DataPropertyName = "VIS_VILLE";
            this.vISVILLEDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.vISVILLEDataGridViewTextBoxColumn.Name = "vISVILLEDataGridViewTextBoxColumn";
            // 
            // vISDATEEMBAUCHEDataGridViewTextBoxColumn
            // 
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.DataPropertyName = "VIS_DATEEMBAUCHE";
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.HeaderText = "Date d\'embauche";
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.Name = "vISDATEEMBAUCHEDataGridViewTextBoxColumn";
            // 
            // visiteursBindingSource3
            // 
            this.visiteursBindingSource3.DataMember = "visiteurs";
            this.visiteursBindingSource3.DataSource = this.gSBPPE3DataSet4BindingSource;
            // 
            // gSBPPE3DataSet4BindingSource
            // 
            this.gSBPPE3DataSet4BindingSource.DataSource = this.gSB_PPE3DataSet4;
            this.gSBPPE3DataSet4BindingSource.Position = 0;
            // 
            // gSB_PPE3DataSet4
            // 
            this.gSB_PPE3DataSet4.DataSetName = "GSB_PPE3DataSet4";
            this.gSB_PPE3DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visiteursBindingSource
            // 
            this.visiteursBindingSource.DataMember = "visiteurs";
            this.visiteursBindingSource.DataSource = this.gSB_PPE3DataSet;
            // 
            // gSB_PPE3DataSet
            // 
            this.gSB_PPE3DataSet.DataSetName = "GSB_PPE3DataSet";
            this.gSB_PPE3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visiteursTableAdapter
            // 
            this.visiteursTableAdapter.ClearBeforeFill = true;
            // 
            // visiteursBindingSource1
            // 
            this.visiteursBindingSource1.DataMember = "visiteurs";
            this.visiteursBindingSource1.DataSource = this.gSB_PPE3DataSet;
            // 
            // visiteursBindingSource2
            // 
            this.visiteursBindingSource2.DataMember = "visiteurs";
            this.visiteursBindingSource2.DataSource = this.gSB_PPE3DataSet4;
            // 
            // visiteursTableAdapter1
            // 
            this.visiteursTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_lstVisiteurs);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.grid_Visiteurs);
            this.Controls.Add(this.btn_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Visiteurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.Form_Visiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Visiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSBPPE3DataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_PPE3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteursBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.DataGridView grid_Visiteurs;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Label lbl_lstVisiteurs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GSB_PPE3DataSet gSB_PPE3DataSet;
        private System.Windows.Forms.BindingSource visiteursBindingSource;
        private GSB_PPE3DataSetTableAdapters.visiteursTableAdapter visiteursTableAdapter;
        private System.Windows.Forms.BindingSource visiteursBindingSource1;
        private GSB_PPE3DataSet4 gSB_PPE3DataSet4;
        private System.Windows.Forms.BindingSource visiteursBindingSource2;
        private GSB_PPE3DataSet4TableAdapters.visiteursTableAdapter visiteursTableAdapter1;
        private System.Windows.Forms.BindingSource gSBPPE3DataSet4BindingSource;
        private System.Windows.Forms.BindingSource visiteursBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISNOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISADRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISVILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISDATEEMBAUCHEDataGridViewTextBoxColumn;
    }
}