namespace Bilten.WinUI
{
    partial class frmMjeraDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMjeraDetalji));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.txtOpisMjere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtKategorijaId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis mjere:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKategorija
            // 
            this.txtKategorija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKategorija.Location = new System.Drawing.Point(162, 143);
            this.txtKategorija.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.ReadOnly = true;
            this.txtKategorija.Size = new System.Drawing.Size(348, 30);
            this.txtKategorija.TabIndex = 2;
            // 
            // txtOpisMjere
            // 
            this.txtOpisMjere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpisMjere.Location = new System.Drawing.Point(162, 220);
            this.txtOpisMjere.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOpisMjere.Name = "txtOpisMjere";
            this.txtOpisMjere.Size = new System.Drawing.Size(622, 30);
            this.txtOpisMjere.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uredi mjeru";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSacuvaj.FlatAppearance.BorderSize = 0;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(592, 286);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(192, 52);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtKategorijaId
            // 
            this.txtKategorijaId.BackColor = System.Drawing.Color.White;
            this.txtKategorijaId.Location = new System.Drawing.Point(721, 41);
            this.txtKategorijaId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKategorijaId.Name = "txtKategorijaId";
            this.txtKategorijaId.ReadOnly = true;
            this.txtKategorijaId.Size = new System.Drawing.Size(63, 37);
            this.txtKategorijaId.TabIndex = 6;
            this.txtKategorijaId.Visible = false;
            this.txtKategorijaId.TextChanged += new System.EventHandler(this.txtKategorijaId_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(29, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 3);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 14);
            this.panel2.TabIndex = 9;
            // 
            // frmMjeraDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKategorijaId);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtOpisMjere);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMjeraDetalji";
            this.Text = "Uredi mjeru";
            this.Load += new System.EventHandler(this.frmMjeraDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.TextBox txtOpisMjere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtKategorijaId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}