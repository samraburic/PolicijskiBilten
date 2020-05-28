namespace Bilten.WinUI.FormaKontrolor
{
    partial class frmSviDogadjaji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSviDogadjaji));
            this.dgvSviDogadjaji = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDatumDogadjaja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PodorganizacionaJedinicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizacionaJedinicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrsteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latituda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longituda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odabran = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviDogadjaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviDogadjaji
            // 
            this.dgvSviDogadjaji.AllowUserToAddRows = false;
            this.dgvSviDogadjaji.AllowUserToDeleteRows = false;
            this.dgvSviDogadjaji.BackgroundColor = System.Drawing.Color.White;
            this.dgvSviDogadjaji.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSviDogadjaji.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSviDogadjaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSviDogadjaji.ColumnHeadersHeight = 45;
            this.dgvSviDogadjaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Kategorije,
            this.Vrste,
            this.DatumPrijave,
            this.DatumDogadjaja,
            this.MjestoDogadjaja,
            this.PodorganizacionaJedinicaId,
            this.OrganizacionaJedinicaId,
            this.VrsteId,
            this.KategorijeId,
            this.Opis,
            this.Latituda,
            this.Longituda,
            this.Odabran});
            this.dgvSviDogadjaji.EnableHeadersVisualStyles = false;
            this.dgvSviDogadjaji.Location = new System.Drawing.Point(23, 123);
            this.dgvSviDogadjaji.Name = "dgvSviDogadjaji";
            this.dgvSviDogadjaji.RowHeadersVisible = false;
            this.dgvSviDogadjaji.RowHeadersWidth = 62;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSviDogadjaji.RowTemplate.DividerHeight = 1;
            this.dgvSviDogadjaji.RowTemplate.Height = 35;
            this.dgvSviDogadjaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviDogadjaji.Size = new System.Drawing.Size(1876, 835);
            this.dgvSviDogadjaji.TabIndex = 0;
            this.dgvSviDogadjaji.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviDogadjaji_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(869, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 60;
            this.button1.Text = "Pretraga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDatumDogadjaja
            // 
            this.dtpDatumDogadjaja.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjaja.Location = new System.Drawing.Point(463, 41);
            this.dtpDatumDogadjaja.Name = "dtpDatumDogadjaja";
            this.dtpDatumDogadjaja.Size = new System.Drawing.Size(368, 34);
            this.dtpDatumDogadjaja.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 39);
            this.label3.TabIndex = 61;
            this.label3.Text = "Svi prijavljeni događaji za datum";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // Kategorije
            // 
            this.Kategorije.DataPropertyName = "Kategorije";
            this.Kategorije.HeaderText = "Kategorije";
            this.Kategorije.MinimumWidth = 8;
            this.Kategorije.Name = "Kategorije";
            this.Kategorije.Width = 150;
            // 
            // Vrste
            // 
            this.Vrste.DataPropertyName = "Vrste";
            this.Vrste.HeaderText = "Vrste";
            this.Vrste.MinimumWidth = 8;
            this.Vrste.Name = "Vrste";
            this.Vrste.Width = 270;
            // 
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "Datum prijave";
            this.DatumPrijave.MinimumWidth = 8;
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.Width = 150;
            // 
            // DatumDogadjaja
            // 
            this.DatumDogadjaja.DataPropertyName = "DatumDogadjaja";
            this.DatumDogadjaja.HeaderText = "Datum događaja";
            this.DatumDogadjaja.MinimumWidth = 8;
            this.DatumDogadjaja.Name = "DatumDogadjaja";
            this.DatumDogadjaja.Width = 150;
            // 
            // MjestoDogadjaja
            // 
            this.MjestoDogadjaja.DataPropertyName = "MjestoDogadjaja";
            this.MjestoDogadjaja.HeaderText = "Mjesto";
            this.MjestoDogadjaja.MinimumWidth = 8;
            this.MjestoDogadjaja.Name = "MjestoDogadjaja";
            // 
            // PodorganizacionaJedinicaId
            // 
            this.PodorganizacionaJedinicaId.DataPropertyName = "PodorganizacionaJedinicaId";
            this.PodorganizacionaJedinicaId.HeaderText = "PodorganizacionaJedinicaId";
            this.PodorganizacionaJedinicaId.MinimumWidth = 8;
            this.PodorganizacionaJedinicaId.Name = "PodorganizacionaJedinicaId";
            this.PodorganizacionaJedinicaId.Visible = false;
            this.PodorganizacionaJedinicaId.Width = 150;
            // 
            // OrganizacionaJedinicaId
            // 
            this.OrganizacionaJedinicaId.DataPropertyName = "OrganizacionaJedinicaId";
            this.OrganizacionaJedinicaId.HeaderText = "OrganizacionaJedinicaId";
            this.OrganizacionaJedinicaId.MinimumWidth = 8;
            this.OrganizacionaJedinicaId.Name = "OrganizacionaJedinicaId";
            this.OrganizacionaJedinicaId.Visible = false;
            this.OrganizacionaJedinicaId.Width = 150;
            // 
            // VrsteId
            // 
            this.VrsteId.DataPropertyName = "VrsteId";
            this.VrsteId.HeaderText = "VrsteId";
            this.VrsteId.MinimumWidth = 8;
            this.VrsteId.Name = "VrsteId";
            this.VrsteId.Visible = false;
            this.VrsteId.Width = 150;
            // 
            // KategorijeId
            // 
            this.KategorijeId.DataPropertyName = "KategorijeId";
            this.KategorijeId.HeaderText = "KategorijeId";
            this.KategorijeId.MinimumWidth = 8;
            this.KategorijeId.Name = "KategorijeId";
            this.KategorijeId.Visible = false;
            this.KategorijeId.Width = 150;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 8;
            this.Opis.Name = "Opis";
            this.Opis.Width = 300;
            // 
            // Latituda
            // 
            this.Latituda.DataPropertyName = "Latituda";
            this.Latituda.HeaderText = "Latituda";
            this.Latituda.MinimumWidth = 8;
            this.Latituda.Name = "Latituda";
            this.Latituda.Visible = false;
            this.Latituda.Width = 150;
            // 
            // Longituda
            // 
            this.Longituda.DataPropertyName = "Longituda";
            this.Longituda.HeaderText = "Longituda";
            this.Longituda.MinimumWidth = 8;
            this.Longituda.Name = "Longituda";
            this.Longituda.Visible = false;
            this.Longituda.Width = 150;
            // 
            // Odabran
            // 
            this.Odabran.DataPropertyName = "Odabran";
            this.Odabran.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Odabran.HeaderText = "Za zvanični";
            this.Odabran.MinimumWidth = 8;
            this.Odabran.Name = "Odabran";
            this.Odabran.Width = 110;
            // 
            // frmSviDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDatumDogadjaja);
            this.Controls.Add(this.dgvSviDogadjaji);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSviDogadjaji";
            this.Text = "Svi prijavljeni događaji";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSviDogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviDogadjaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviDogadjaji;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrste;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn PodorganizacionaJedinicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizacionaJedinicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrsteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latituda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longituda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odabran;
    }
}