namespace Bilten.WinUI
{
    partial class frmOsobeSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOsobeSearch));
            this.dgvOsobe = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrLicneKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.txtPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsobe
            // 
            this.dgvOsobe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsobe.BackgroundColor = System.Drawing.Color.White;
            this.dgvOsobe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsobe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOsobe.ColumnHeadersHeight = 45;
            this.dgvOsobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.BrLicneKarte,
            this.JMBG,
            this.DatumRodjenja});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOsobe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOsobe.EnableHeadersVisualStyles = false;
            this.dgvOsobe.Location = new System.Drawing.Point(13, 181);
            this.dgvOsobe.Name = "dgvOsobe";
            this.dgvOsobe.RowHeadersVisible = false;
            this.dgvOsobe.RowHeadersWidth = 62;
            this.dgvOsobe.RowTemplate.Height = 35;
            this.dgvOsobe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsobe.Size = new System.Drawing.Size(1120, 501);
            this.dgvOsobe.TabIndex = 0;
            this.dgvOsobe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOsobe_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 8;
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 8;
            this.Prezime.Name = "Prezime";
            // 
            // BrLicneKarte
            // 
            this.BrLicneKarte.DataPropertyName = "BrLicneKarte";
            this.BrLicneKarte.HeaderText = "Br. lične karte";
            this.BrLicneKarte.MinimumWidth = 8;
            this.BrLicneKarte.Name = "BrLicneKarte";
            // 
            // JMBG
            // 
            this.JMBG.DataPropertyName = "Jmbg";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.MinimumWidth = 8;
            this.JMBG.Name = "JMBG";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.MinimumWidth = 8;
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(13, 119);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(349, 34);
            this.txtPretraga.TabIndex = 1;
            // 
            // txtPrikazi
            // 
            this.txtPrikazi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrikazi.FlatAppearance.BorderSize = 0;
            this.txtPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPrikazi.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrikazi.ForeColor = System.Drawing.Color.White;
            this.txtPrikazi.Location = new System.Drawing.Point(394, 119);
            this.txtPrikazi.Name = "txtPrikazi";
            this.txtPrikazi.Size = new System.Drawing.Size(111, 34);
            this.txtPrikazi.TabIndex = 2;
            this.txtPrikazi.Text = "Prikaži";
            this.txtPrikazi.UseVisualStyleBackColor = false;
            this.txtPrikazi.Click += new System.EventHandler(this.txtPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga osoba po br. lične karte, JMBG-u, imenu i prezimenu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registar osoba";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Bilten.WinUI.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(996, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // frmOsobeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(152)))));
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 694);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvOsobe);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOsobeSearch";
            this.Text = "Registar osoba - dodaj osobu";
            this.Load += new System.EventHandler(this.frmOsobeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOsobe;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button txtPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrLicneKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}