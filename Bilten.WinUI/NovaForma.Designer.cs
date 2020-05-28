namespace Bilten.WinUI
{
    partial class NovaForma
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
            this.comboKategorije = new System.Windows.Forms.ComboBox();
            this.comboVrste = new System.Windows.Forms.ComboBox();
            this.gridVrste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridVrste)).BeginInit();
            this.SuspendLayout();
            // 
            // comboKategorije
            // 
            this.comboKategorije.FormattingEnabled = true;
            this.comboKategorije.Location = new System.Drawing.Point(94, 85);
            this.comboKategorije.Name = "comboKategorije";
            this.comboKategorije.Size = new System.Drawing.Size(320, 28);
            this.comboKategorije.TabIndex = 0;
            this.comboKategorije.SelectedIndexChanged += new System.EventHandler(this.comboKategorije_SelectedIndexChanged);
            // 
            // comboVrste
            // 
            this.comboVrste.FormattingEnabled = true;
            this.comboVrste.Location = new System.Drawing.Point(94, 141);
            this.comboVrste.Name = "comboVrste";
            this.comboVrste.Size = new System.Drawing.Size(467, 28);
            this.comboVrste.TabIndex = 1;
            // 
            // gridVrste
            // 
            this.gridVrste.AllowUserToAddRows = false;
            this.gridVrste.AllowUserToDeleteRows = false;
            this.gridVrste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVrste.Location = new System.Drawing.Point(94, 200);
            this.gridVrste.Name = "gridVrste";
            this.gridVrste.ReadOnly = true;
            this.gridVrste.RowHeadersWidth = 62;
            this.gridVrste.RowTemplate.Height = 28;
            this.gridVrste.Size = new System.Drawing.Size(591, 400);
            this.gridVrste.TabIndex = 2;
            // 
            // NovaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 616);
            this.Controls.Add(this.gridVrste);
            this.Controls.Add(this.comboVrste);
            this.Controls.Add(this.comboKategorije);
            this.Name = "NovaForma";
            this.Text = "NovaForma";
            this.Load += new System.EventHandler(this.NovaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVrste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKategorije;
        private System.Windows.Forms.ComboBox comboVrste;
        private System.Windows.Forms.DataGridView gridVrste;
    }
}