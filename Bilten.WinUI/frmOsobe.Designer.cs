namespace Bilten.WinUI
{
    partial class frmOsobe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOsobe));
            this.dgvOsobe = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrLicneKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajOsobu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsobe
            // 
            this.dgvOsobe.AllowUserToAddRows = false;
            this.dgvOsobe.AllowUserToDeleteRows = false;
            this.dgvOsobe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsobe.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvOsobe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOsobe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsobe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOsobe.ColumnHeadersHeight = 50;
            this.dgvOsobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.BrLicneKarte,
            this.JMBG,
            this.DatumRodjenja});
            this.dgvOsobe.Location = new System.Drawing.Point(13, 101);
            this.dgvOsobe.Name = "dgvOsobe";
            this.dgvOsobe.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsobe.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOsobe.RowHeadersVisible = false;
            this.dgvOsobe.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvOsobe.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOsobe.RowTemplate.Height = 28;
            this.dgvOsobe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsobe.Size = new System.Drawing.Size(1142, 472);
            this.dgvOsobe.TabIndex = 0;
            this.dgvOsobe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOsobe_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 8;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 8;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // BrLicneKarte
            // 
            this.BrLicneKarte.DataPropertyName = "BrLicneKarte";
            this.BrLicneKarte.HeaderText = "BrLicneKarte";
            this.BrLicneKarte.MinimumWidth = 8;
            this.BrLicneKarte.Name = "BrLicneKarte";
            this.BrLicneKarte.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.MinimumWidth = 8;
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "DatumRodjenja";
            this.DatumRodjenja.MinimumWidth = 8;
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // btnDodajOsobu
            // 
            this.btnDodajOsobu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajOsobu.FlatAppearance.BorderSize = 0;
            this.btnDodajOsobu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajOsobu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOsobu.ForeColor = System.Drawing.Color.White;
            this.btnDodajOsobu.Location = new System.Drawing.Point(990, 17);
            this.btnDodajOsobu.Name = "btnDodajOsobu";
            this.btnDodajOsobu.Size = new System.Drawing.Size(165, 44);
            this.btnDodajOsobu.TabIndex = 1;
            this.btnDodajOsobu.Text = "Dodaj osobu";
            this.btnDodajOsobu.UseVisualStyleBackColor = false;
            this.btnDodajOsobu.Click += new System.EventHandler(this.btnDodajOsobu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 3);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 49);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registar osoba";
            // 
            // frmOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajOsobu);
            this.Controls.Add(this.dgvOsobe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOsobe";
            this.Text = "Registar osoba";
            this.Load += new System.EventHandler(this.frmOsobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOsobe;
        private System.Windows.Forms.Button btnDodajOsobu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrLicneKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
    }
}