namespace PPE3_GSB_WF.UI
{
    partial class Form_Echantillon_Offrir
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
            this.med1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_qt = new System.Windows.Forms.TextBox();
            this.bt_valid = new System.Windows.Forms.Button();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.med1.SuspendLayout();
            this.SuspendLayout();
            // 
            // med1
            // 
            this.med1.Controls.Add(this.cb_select);
            this.med1.Controls.Add(this.label2);
            this.med1.Controls.Add(this.label3);
            this.med1.Controls.Add(this.tb_qt);
            this.med1.Location = new System.Drawing.Point(15, 12);
            this.med1.Name = "med1";
            this.med1.Size = new System.Drawing.Size(656, 40);
            this.med1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nom du médicament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quantité";
            // 
            // tb_qt
            // 
            this.tb_qt.Location = new System.Drawing.Point(479, 11);
            this.tb_qt.MaxLength = 3;
            this.tb_qt.Name = "tb_qt";
            this.tb_qt.Size = new System.Drawing.Size(156, 22);
            this.tb_qt.TabIndex = 7;
            this.tb_qt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qt_KeyPress);
            // 
            // bt_valid
            // 
            this.bt_valid.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.Location = new System.Drawing.Point(266, 59);
            this.bt_valid.Margin = new System.Windows.Forms.Padding(4);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(139, 37);
            this.bt_valid.TabIndex = 38;
            this.bt_valid.Text = "Valider";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.bt_valid_Click);
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
            // Form_Echantillon_Offrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 101);
            this.Controls.Add(this.bt_valid);
            this.Controls.Add(this.med1);
            this.Name = "Form_Echantillon_Offrir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un échantillon";
            this.Load += new System.EventHandler(this.Form_Echantillon_Offrir_Load);
            this.med1.ResumeLayout(false);
            this.med1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel med1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_qt;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.ComboBox cb_select;
    }
}