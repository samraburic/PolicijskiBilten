namespace Bilten.WinUI
{
    partial class frmDogadjajDodajMjere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDogadjajDodajMjere));
            this.txtDogadjajId = new System.Windows.Forms.TextBox();
            this.clbMjere = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategorijaID = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDogadjajId
            // 
            this.txtDogadjajId.Location = new System.Drawing.Point(12, 456);
            this.txtDogadjajId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDogadjajId.Name = "txtDogadjajId";
            this.txtDogadjajId.Size = new System.Drawing.Size(188, 37);
            this.txtDogadjajId.TabIndex = 1;
            this.txtDogadjajId.Visible = false;
            // 
            // clbMjere
            // 
            this.clbMjere.CheckOnClick = true;
            this.clbMjere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbMjere.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMjere.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clbMjere.FormattingEnabled = true;
            this.clbMjere.Location = new System.Drawing.Point(14, 98);
            this.clbMjere.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.clbMjere.Name = "clbMjere";
            this.clbMjere.Size = new System.Drawing.Size(584, 310);
            this.clbMjere.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 411);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "DogadjajID";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "KategorijaID";
            this.label2.Visible = false;
            // 
            // txtKategorijaID
            // 
            this.txtKategorijaID.Location = new System.Drawing.Point(209, 456);
            this.txtKategorijaID.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtKategorijaID.Name = "txtKategorijaID";
            this.txtKategorijaID.Size = new System.Drawing.Size(196, 37);
            this.txtKategorijaID.TabIndex = 5;
            this.txtKategorijaID.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(420, 449);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(178, 48);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Sačuvaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodavanje poduzetih mjera";
            // 
            // frmDogadjajDodajMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKategorijaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbMjere);
            this.Controls.Add(this.txtDogadjajId);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDogadjajDodajMjere";
            this.Text = "Mjere događaja";
            this.Load += new System.EventHandler(this.frmDogadjajDodajMjere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDogadjajId;
        private System.Windows.Forms.CheckedListBox clbMjere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategorijaID;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
    }
}