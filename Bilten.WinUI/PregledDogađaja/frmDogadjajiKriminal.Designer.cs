namespace Bilten.WinUI.PregledDogađaja
{
    partial class frmDogadjajiKriminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDogadjajiKriminal));
            this.dgvDogadjajiKriminal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDatumDogadjajaDO = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDogadjajaOD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjajiKriminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDogadjajiKriminal
            // 
            this.dgvDogadjajiKriminal.AllowUserToAddRows = false;
            this.dgvDogadjajiKriminal.AllowUserToDeleteRows = false;
            this.dgvDogadjajiKriminal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDogadjajiKriminal.BackgroundColor = System.Drawing.Color.White;
            this.dgvDogadjajiKriminal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDogadjajiKriminal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDogadjajiKriminal.ColumnHeadersHeight = 40;
            this.dgvDogadjajiKriminal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KategorijeId,
            this.Kategorije,
            this.Vrste,
            this.DatumPrijave,
            this.DatumDogadjaja,
            this.MjestoDogadjaja,
            this.Opis});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDogadjajiKriminal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDogadjajiKriminal.EnableHeadersVisualStyles = false;
            this.dgvDogadjajiKriminal.Location = new System.Drawing.Point(12, 183);
            this.dgvDogadjajiKriminal.Name = "dgvDogadjajiKriminal";
            this.dgvDogadjajiKriminal.ReadOnly = true;
            this.dgvDogadjajiKriminal.RowHeadersVisible = false;
            this.dgvDogadjajiKriminal.RowHeadersWidth = 62;
            this.dgvDogadjajiKriminal.RowTemplate.Height = 35;
            this.dgvDogadjajiKriminal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDogadjajiKriminal.Size = new System.Drawing.Size(1120, 509);
            this.dgvDogadjajiKriminal.TabIndex = 0;
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
            // KategorijeId
            // 
            this.KategorijeId.DataPropertyName = "KategorijeId";
            this.KategorijeId.HeaderText = "KategorijeId";
            this.KategorijeId.MinimumWidth = 8;
            this.KategorijeId.Name = "KategorijeId";
            this.KategorijeId.ReadOnly = true;
            this.KategorijeId.Visible = false;
            // 
            // Kategorije
            // 
            this.Kategorije.DataPropertyName = "Kategorije";
            this.Kategorije.HeaderText = "Kategorija";
            this.Kategorije.MinimumWidth = 8;
            this.Kategorije.Name = "Kategorije";
            this.Kategorije.ReadOnly = true;
            // 
            // Vrste
            // 
            this.Vrste.DataPropertyName = "Vrste";
            this.Vrste.HeaderText = "Vrste";
            this.Vrste.MinimumWidth = 8;
            this.Vrste.Name = "Vrste";
            this.Vrste.ReadOnly = true;
            // 
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "Datum prijave";
            this.DatumPrijave.MinimumWidth = 8;
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.ReadOnly = true;
            // 
            // DatumDogadjaja
            // 
            this.DatumDogadjaja.DataPropertyName = "DatumDogadjaja";
            this.DatumDogadjaja.HeaderText = "Datum događaja";
            this.DatumDogadjaja.MinimumWidth = 8;
            this.DatumDogadjaja.Name = "DatumDogadjaja";
            this.DatumDogadjaja.ReadOnly = true;
            // 
            // MjestoDogadjaja
            // 
            this.MjestoDogadjaja.DataPropertyName = "MjestoDogadjaja";
            this.MjestoDogadjaja.HeaderText = "Mjesto";
            this.MjestoDogadjaja.MinimumWidth = 8;
            this.MjestoDogadjaja.Name = "MjestoDogadjaja";
            this.MjestoDogadjaja.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 8;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Svi prijavljeni događaji iz kategorije \"Kriminal\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pregled događaja";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Bilten.WinUI.Properties.Resources.crime_scene_png_hd_police_tape_png_1600;
            this.pictureBox3.Location = new System.Drawing.Point(1002, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(381, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 35);
            this.label3.TabIndex = 57;
            this.label3.Text = "do";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(799, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 56;
            this.button1.Text = "Pretraga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDatumDogadjajaDO
            // 
            this.dtpDatumDogadjajaDO.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaDO.Location = new System.Drawing.Point(437, 136);
            this.dtpDatumDogadjajaDO.Name = "dtpDatumDogadjajaDO";
            this.dtpDatumDogadjajaDO.Size = new System.Drawing.Size(332, 32);
            this.dtpDatumDogadjajaDO.TabIndex = 55;
            // 
            // dtpDatumDogadjajaOD
            // 
            this.dtpDatumDogadjajaOD.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaOD.Location = new System.Drawing.Point(63, 136);
            this.dtpDatumDogadjajaOD.Name = "dtpDatumDogadjajaOD";
            this.dtpDatumDogadjajaOD.Size = new System.Drawing.Size(311, 32);
            this.dtpDatumDogadjajaOD.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 35);
            this.label4.TabIndex = 60;
            this.label4.Text = "Od";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 3);
            this.panel1.TabIndex = 62;
            // 
            // frmDogadjajiKriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDatumDogadjajaDO);
            this.Controls.Add(this.dtpDatumDogadjajaOD);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDogadjajiKriminal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDogadjajiKriminal";
            this.Text = "Kriminalni događaji";
            this.Load += new System.EventHandler(this.frmDogadjajiKriminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjajiKriminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDogadjajiKriminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrste;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjajaDO;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjajaOD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}