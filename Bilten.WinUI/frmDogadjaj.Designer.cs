namespace Bilten.WinUI
{
    partial class frmDogadjaj
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
            System.Windows.Forms.Button btnSacuvaj;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDogadjaj));
            this.dgvDogadjaji = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatumDogadjajaOD = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDogadjajaDO = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrsteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodajMjere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DodajSlike = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Video = new System.Windows.Forms.DataGridViewButtonColumn();
            btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = System.Drawing.Color.DodgerBlue;
            btnSacuvaj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            btnSacuvaj.FlatAppearance.BorderSize = 0;
            btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSacuvaj.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSacuvaj.ForeColor = System.Drawing.Color.White;
            btnSacuvaj.Image = global::Bilten.WinUI.Properties.Resources.plus__5_;
            btnSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSacuvaj.Location = new System.Drawing.Point(1627, 163);
            btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new System.Drawing.Size(246, 51);
            btnSacuvaj.TabIndex = 46;
            btnSacuvaj.Text = "    Novi događaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgvDogadjaji
            // 
            this.dgvDogadjaji.AllowUserToAddRows = false;
            this.dgvDogadjaji.AllowUserToDeleteRows = false;
            this.dgvDogadjaji.BackgroundColor = System.Drawing.Color.White;
            this.dgvDogadjaji.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDogadjaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDogadjaji.ColumnHeadersHeight = 45;
            this.dgvDogadjaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KategorijeId,
            this.VrsteId,
            this.Kategorija,
            this.DatumDogadjaja,
            this.Vrsta,
            this.DatumPrijave,
            this.Opis,
            this.DodajMjere,
            this.DodajSlike,
            this.Video});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDogadjaji.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDogadjaji.EnableHeadersVisualStyles = false;
            this.dgvDogadjaji.Location = new System.Drawing.Point(28, 227);
            this.dgvDogadjaji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDogadjaji.Name = "dgvDogadjaji";
            this.dgvDogadjaji.ReadOnly = true;
            this.dgvDogadjaji.RowHeadersVisible = false;
            this.dgvDogadjaji.RowHeadersWidth = 70;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDogadjaji.RowTemplate.DividerHeight = 1;
            this.dgvDogadjaji.RowTemplate.Height = 35;
            this.dgvDogadjaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDogadjaji.Size = new System.Drawing.Size(1860, 760);
            this.dgvDogadjaji.TabIndex = 0;
            this.dgvDogadjaji.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDogadjaji_CellClick);
            this.dgvDogadjaji.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDogadjaji_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(550, 49);
            this.label10.TabIndex = 43;
            this.label10.Text = "Bilten svih prijavljenih događaja";
            // 
            // dtpDatumDogadjajaOD
            // 
            this.dtpDatumDogadjajaOD.CalendarFont = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaOD.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaOD.Location = new System.Drawing.Point(46, 47);
            this.dtpDatumDogadjajaOD.Name = "dtpDatumDogadjajaOD";
            this.dtpDatumDogadjajaOD.Size = new System.Drawing.Size(337, 32);
            this.dtpDatumDogadjajaOD.TabIndex = 47;
            // 
            // dtpDatumDogadjajaDO
            // 
            this.dtpDatumDogadjajaDO.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaDO.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaDO.Location = new System.Drawing.Point(438, 47);
            this.dtpDatumDogadjajaDO.Name = "dtpDatumDogadjajaDO";
            this.dtpDatumDogadjajaDO.Size = new System.Drawing.Size(340, 32);
            this.dtpDatumDogadjajaDO.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(388, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "DO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "OD";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDatumDogadjajaOD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDatumDogadjajaDO);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 103);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po datumu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bilten.WinUI.Properties.Resources.search__1_;
            this.pictureBox1.Location = new System.Drawing.Point(794, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // KategorijeId
            // 
            this.KategorijeId.DataPropertyName = "KategorijeId";
            this.KategorijeId.HeaderText = "KategorijeId";
            this.KategorijeId.MinimumWidth = 8;
            this.KategorijeId.Name = "KategorijeId";
            this.KategorijeId.ReadOnly = true;
            this.KategorijeId.Visible = false;
            this.KategorijeId.Width = 150;
            // 
            // VrsteId
            // 
            this.VrsteId.DataPropertyName = "VrsteId";
            this.VrsteId.HeaderText = "VrsteId";
            this.VrsteId.MinimumWidth = 8;
            this.VrsteId.Name = "VrsteId";
            this.VrsteId.ReadOnly = true;
            this.VrsteId.Visible = false;
            this.VrsteId.Width = 150;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorije";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 8;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            this.Kategorija.Width = 120;
            // 
            // DatumDogadjaja
            // 
            this.DatumDogadjaja.DataPropertyName = "DatumDogadjaja";
            this.DatumDogadjaja.HeaderText = "Datum događaja";
            this.DatumDogadjaja.MinimumWidth = 8;
            this.DatumDogadjaja.Name = "DatumDogadjaja";
            this.DatumDogadjaja.ReadOnly = true;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrste";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.MinimumWidth = 8;
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            this.Vrsta.Width = 260;
            // 
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "Datum prijave";
            this.DatumPrijave.MinimumWidth = 8;
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 8;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 320;
            // 
            // DodajMjere
            // 
            this.DodajMjere.DataPropertyName = "DodajMjere";
            this.DodajMjere.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DodajMjere.HeaderText = "Mjere";
            this.DodajMjere.MinimumWidth = 8;
            this.DodajMjere.Name = "DodajMjere";
            this.DodajMjere.ReadOnly = true;
            this.DodajMjere.Text = "Mjere";
            this.DodajMjere.UseColumnTextForButtonValue = true;
            // 
            // DodajSlike
            // 
            this.DodajSlike.DataPropertyName = "Slike";
            this.DodajSlike.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DodajSlike.HeaderText = "Slike";
            this.DodajSlike.MinimumWidth = 8;
            this.DodajSlike.Name = "DodajSlike";
            this.DodajSlike.ReadOnly = true;
            this.DodajSlike.Text = "Slike";
            this.DodajSlike.UseColumnTextForButtonValue = true;
            // 
            // Video
            // 
            this.Video.DataPropertyName = "Video";
            this.Video.HeaderText = "Video";
            this.Video.MinimumWidth = 8;
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            this.Video.Text = "Video";
            this.Video.UseColumnTextForButtonValue = true;
            // 
            // frmDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1886, 1030);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(btnSacuvaj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDogadjaji);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDogadjaj";
            this.Text = "Događaji";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDogadjaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDogadjaji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjajaOD;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjajaDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrsteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewButtonColumn DodajMjere;
        private System.Windows.Forms.DataGridViewButtonColumn DodajSlike;
        private System.Windows.Forms.DataGridViewButtonColumn Video;
    }
}