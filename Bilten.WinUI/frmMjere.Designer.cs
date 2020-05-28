namespace Bilten.WinUI
{
    partial class frmMjere
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMjere));
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.dgvMjere = new System.Windows.Forms.DataGridView();
            this.MjeraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisMjere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjere)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(203, 141);
            this.cmbKategorije.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(296, 37);
            this.cmbKategorije.TabIndex = 0;
            this.cmbKategorije.SelectedIndexChanged += new System.EventHandler(this.cmbKategorije_SelectedIndexChanged);
            // 
            // dgvMjere
            // 
            this.dgvMjere.AllowUserToAddRows = false;
            this.dgvMjere.AllowUserToDeleteRows = false;
            this.dgvMjere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMjere.BackgroundColor = System.Drawing.Color.White;
            this.dgvMjere.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMjere.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMjere.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMjere.ColumnHeadersHeight = 50;
            this.dgvMjere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MjeraId,
            this.OpisMjere,
            this.KategorijaId,
            this.btnDelete});
            this.dgvMjere.Location = new System.Drawing.Point(43, 211);
            this.dgvMjere.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMjere.Name = "dgvMjere";
            this.dgvMjere.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMjere.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMjere.RowHeadersVisible = false;
            this.dgvMjere.RowHeadersWidth = 62;
            this.dgvMjere.RowTemplate.Height = 28;
            this.dgvMjere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMjere.Size = new System.Drawing.Size(668, 442);
            this.dgvMjere.TabIndex = 1;
            this.dgvMjere.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMjere_CellDoubleClick);
            // 
            // MjeraId
            // 
            this.MjeraId.DataPropertyName = "Id";
            this.MjeraId.HeaderText = "Id";
            this.MjeraId.MinimumWidth = 8;
            this.MjeraId.Name = "MjeraId";
            this.MjeraId.ReadOnly = true;
            this.MjeraId.Visible = false;
            // 
            // OpisMjere
            // 
            this.OpisMjere.DataPropertyName = "Opis";
            this.OpisMjere.FillWeight = 190.9091F;
            this.OpisMjere.HeaderText = "Opis mjere";
            this.OpisMjere.MinimumWidth = 8;
            this.OpisMjere.Name = "OpisMjere";
            this.OpisMjere.ReadOnly = true;
            // 
            // KategorijaId
            // 
            this.KategorijaId.DataPropertyName = "KategorijaId";
            this.KategorijaId.HeaderText = "KategorijaId";
            this.KategorijaId.MinimumWidth = 8;
            this.KategorijaId.Name = "KategorijaId";
            this.KategorijaId.ReadOnly = true;
            this.KategorijaId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 9.090912F;
            this.btnDelete.HeaderText = "Akcija";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Akcija";
            this.dataGridViewImageColumn1.Image = global::Bilten.WinUI.Properties.Resources.quit__1_;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mjere događaja";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 3);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategorija:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSacuvaj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSacuvaj.FlatAppearance.BorderSize = 0;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(539, 133);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 52);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Dodaj novu";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // frmMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 699);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMjere);
            this.Controls.Add(this.cmbKategorije);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMjere";
            this.Text = "Mjere - Pregled mjera";
            this.Load += new System.EventHandler(this.frmMjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.DataGridView dgvMjere;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjeraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisMjere;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}