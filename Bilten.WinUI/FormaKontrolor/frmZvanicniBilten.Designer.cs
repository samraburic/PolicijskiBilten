namespace Bilten.WinUI.FormaKontrolor
{
    partial class frmZvanicniBilten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZvanicniBilten));
            this.dgvSviDogadjaji = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDatumDogadjaja = new System.Windows.Forms.DateTimePicker();
            this.Kategorije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoDogadjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odabran = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviDogadjaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviDogadjaji
            // 
            this.dgvSviDogadjaji.AllowUserToAddRows = false;
            this.dgvSviDogadjaji.AllowUserToDeleteRows = false;
            this.dgvSviDogadjaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviDogadjaji.BackgroundColor = System.Drawing.Color.White;
            this.dgvSviDogadjaji.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSviDogadjaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSviDogadjaji.ColumnHeadersHeight = 45;
            this.dgvSviDogadjaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategorije,
            this.Vrste,
            this.DatumPrijave,
            this.DatumDogadjaja,
            this.MjestoDogadjaja,
            this.Opis,
            this.Odabran});
            this.dgvSviDogadjaji.EnableHeadersVisualStyles = false;
            this.dgvSviDogadjaji.Location = new System.Drawing.Point(25, 203);
            this.dgvSviDogadjaji.Name = "dgvSviDogadjaji";
            this.dgvSviDogadjaji.ReadOnly = true;
            this.dgvSviDogadjaji.RowHeadersVisible = false;
            this.dgvSviDogadjaji.RowHeadersWidth = 62;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvSviDogadjaji.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSviDogadjaji.RowTemplate.DividerHeight = 1;
            this.dgvSviDogadjaji.RowTemplate.Height = 35;
            this.dgvSviDogadjaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviDogadjaji.Size = new System.Drawing.Size(1871, 734);
            this.dgvSviDogadjaji.TabIndex = 1;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Image = global::Bilten.WinUI.Properties.Resources.pdf__1_;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(1680, 35);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(208, 55);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "     Export";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 13);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 64);
            this.label2.TabIndex = 25;
            this.label2.Text = "Zvanični bilten događaja";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2100, 3);
            this.panel3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 64;
            this.label3.Text = "Zvanični bilten za datum";
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
            this.button1.Location = new System.Drawing.Point(676, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 63;
            this.button1.Text = "Prikaži";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDatumDogadjaja
            // 
            this.dtpDatumDogadjaja.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDogadjaja.Location = new System.Drawing.Point(281, 140);
            this.dtpDatumDogadjaja.Name = "dtpDatumDogadjaja";
            this.dtpDatumDogadjaja.Size = new System.Drawing.Size(368, 34);
            this.dtpDatumDogadjaja.TabIndex = 62;
            // 
            // Kategorije
            // 
            this.Kategorije.DataPropertyName = "Kategorije";
            this.Kategorije.HeaderText = "Kategorije";
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
            // Odabran
            // 
            this.Odabran.DataPropertyName = "Odabran";
            this.Odabran.HeaderText = "Odabran";
            this.Odabran.MinimumWidth = 8;
            this.Odabran.Name = "Odabran";
            this.Odabran.ReadOnly = true;
            // 
            // frmZvanicniBilten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDatumDogadjaja);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dgvSviDogadjaji);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZvanicniBilten";
            this.Text = "Zvanični bilten";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmZvanicniBilten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviDogadjaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviDogadjaji;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDatumDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrste;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoDogadjaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odabran;
    }
}