namespace Bilten.WinUI.PregledDogađaja
{
    partial class frmDogadjajiSaobracaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDogadjajiSaobracaj));
            this.dgvDogadjaji = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDatumDogadjajaDO = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDogadjajaOD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDogadjaji
            // 
            this.dgvDogadjaji.AllowUserToAddRows = false;
            this.dgvDogadjaji.AllowUserToDeleteRows = false;
            this.dgvDogadjaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDogadjaji.BackgroundColor = System.Drawing.Color.White;
            this.dgvDogadjaji.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDogadjaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDogadjaji.ColumnHeadersHeight = 40;
            this.dgvDogadjaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Kategorije,
            this.Vrste,
            this.DatumPrijave,
            this.DatumDogadjaja,
            this.Opis});
            this.dgvDogadjaji.EnableHeadersVisualStyles = false;
            this.dgvDogadjaji.Location = new System.Drawing.Point(12, 193);
            this.dgvDogadjaji.Name = "dgvDogadjaji";
            this.dgvDogadjaji.ReadOnly = true;
            this.dgvDogadjaji.RowHeadersVisible = false;
            this.dgvDogadjaji.RowHeadersWidth = 62;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvDogadjaji.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDogadjaji.RowTemplate.Height = 35;
            this.dgvDogadjaji.Size = new System.Drawing.Size(1120, 489);
            this.dgvDogadjaji.TabIndex = 0;
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
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 8;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Bilten.WinUI.Properties.Resources.police_car_png_background_image_png_arts_police_car_png_transparent_background_450_340;
            this.pictureBox3.Location = new System.Drawing.Point(990, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pregled događaja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Svi prijavljeni događaji iz kategorije \"Saobraćaj\"";
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
            this.button1.Location = new System.Drawing.Point(804, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 52;
            this.button1.Text = "Pretraga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDatumDogadjajaDO
            // 
            this.dtpDatumDogadjajaDO.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaDO.Location = new System.Drawing.Point(442, 142);
            this.dtpDatumDogadjajaDO.Name = "dtpDatumDogadjajaDO";
            this.dtpDatumDogadjajaDO.Size = new System.Drawing.Size(332, 32);
            this.dtpDatumDogadjajaDO.TabIndex = 51;
            // 
            // dtpDatumDogadjajaOD
            // 
            this.dtpDatumDogadjajaOD.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjajaOD.Location = new System.Drawing.Point(68, 142);
            this.dtpDatumDogadjajaOD.Name = "dtpDatumDogadjajaOD";
            this.dtpDatumDogadjajaOD.Size = new System.Drawing.Size(311, 32);
            this.dtpDatumDogadjajaOD.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(386, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 35);
            this.label3.TabIndex = 53;
            this.label3.Text = "do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 35);
            this.label4.TabIndex = 60;
            this.label4.Text = "Od";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 3);
            this.panel1.TabIndex = 61;
            // 
            // frmDogadjajiSaobracaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDatumDogadjajaDO);
            this.Controls.Add(this.dtpDatumDogadjajaOD);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDogadjaji);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDogadjajiSaobracaj";
            this.Text = "Kriminalni događaji";
            this.Load += new System.EventHandler(this.frmDogadjajiSaobracaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadjaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDogadjaji;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrste;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjajaDO;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjajaOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}