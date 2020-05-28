namespace Bilten.WinUI
{
    partial class frmDodajOsobu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajOsobu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JMBG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtBrLicneKarte = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.calDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbExtractedFaces = new System.Windows.Forms.PictureBox();
            this.txtNazivSlike = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // JMBG
            // 
            this.JMBG.AutoSize = true;
            this.JMBG.BackColor = System.Drawing.Color.Transparent;
            this.JMBG.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMBG.ForeColor = System.Drawing.Color.White;
            this.JMBG.Location = new System.Drawing.Point(77, 154);
            this.JMBG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JMBG.Name = "JMBG";
            this.JMBG.Size = new System.Drawing.Size(46, 18);
            this.JMBG.TabIndex = 2;
            this.JMBG.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Br. lične karte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum rođenja:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(128, 73);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(205, 20);
            this.txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(128, 113);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(205, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(128, 155);
            this.txtJMBG.Margin = new System.Windows.Forms.Padding(2);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(205, 20);
            this.txtJMBG.TabIndex = 7;
            // 
            // txtBrLicneKarte
            // 
            this.txtBrLicneKarte.Location = new System.Drawing.Point(128, 197);
            this.txtBrLicneKarte.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrLicneKarte.Name = "txtBrLicneKarte";
            this.txtBrLicneKarte.Size = new System.Drawing.Size(205, 20);
            this.txtBrLicneKarte.TabIndex = 8;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSnimi.FlatAppearance.BorderSize = 0;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(347, 239);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(127, 31);
            this.btnSnimi.TabIndex = 10;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // calDatumRodjenja
            // 
            this.calDatumRodjenja.Location = new System.Drawing.Point(128, 239);
            this.calDatumRodjenja.Margin = new System.Windows.Forms.Padding(2);
            this.calDatumRodjenja.Name = "calDatumRodjenja";
            this.calDatumRodjenja.Size = new System.Drawing.Size(205, 20);
            this.calDatumRodjenja.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 276);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 2);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dodaj novu osobu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 10);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(11, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 2);
            this.panel3.TabIndex = 17;
            // 
            // CamImageBox
            // 
            this.CamImageBox.Location = new System.Drawing.Point(13, 283);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(310, 237);
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(248, 539);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbExtractedFaces
            // 
            this.pbExtractedFaces.Location = new System.Drawing.Point(347, 321);
            this.pbExtractedFaces.Name = "pbExtractedFaces";
            this.pbExtractedFaces.Size = new System.Drawing.Size(127, 111);
            this.pbExtractedFaces.TabIndex = 19;
            this.pbExtractedFaces.TabStop = false;
            // 
            // txtNazivSlike
            // 
            this.txtNazivSlike.Location = new System.Drawing.Point(347, 456);
            this.txtNazivSlike.Name = "txtNazivSlike";
            this.txtNazivSlike.Size = new System.Drawing.Size(127, 20);
            this.txtNazivSlike.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(344, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Naziv slike:";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSliku.FlatAppearance.BorderSize = 0;
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSliku.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.ForeColor = System.Drawing.Color.White;
            this.btnDodajSliku.Location = new System.Drawing.Point(347, 489);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(127, 31);
            this.btnDodajSliku.TabIndex = 23;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDodajOsobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 574);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNazivSlike);
            this.Controls.Add(this.pbExtractedFaces);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.CamImageBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calDatumRodjenja);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtBrLicneKarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JMBG);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDodajOsobu";
            this.Text = "Dodaj osobu";
            this.Load += new System.EventHandler(this.frmDodajOsobu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedFaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label JMBG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtBrLicneKarte;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DateTimePicker calDatumRodjenja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbExtractedFaces;
        private System.Windows.Forms.TextBox txtNazivSlike;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}