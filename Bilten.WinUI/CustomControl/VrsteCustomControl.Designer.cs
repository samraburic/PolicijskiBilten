﻿namespace Bilten.WinUI.CustomControl
{
    partial class VrsteCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajVrstu = new System.Windows.Forms.Button();
            this.btnPregledVrsta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(942, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prikaz i evidencija svih vrsta prekršaja, kriminalnih događaja i događaja iz saob" +
    "raćaja/prometa.";
            // 
            // btnDodajVrstu
            // 
            this.btnDodajVrstu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodajVrstu.FlatAppearance.BorderSize = 0;
            this.btnDodajVrstu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVrstu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVrstu.ForeColor = System.Drawing.Color.White;
            this.btnDodajVrstu.Location = new System.Drawing.Point(637, 408);
            this.btnDodajVrstu.Name = "btnDodajVrstu";
            this.btnDodajVrstu.Size = new System.Drawing.Size(202, 52);
            this.btnDodajVrstu.TabIndex = 8;
            this.btnDodajVrstu.Text = "Klikni";
            this.btnDodajVrstu.UseVisualStyleBackColor = false;
            this.btnDodajVrstu.Click += new System.EventHandler(this.btnDodajVrstu_Click);
            // 
            // btnPregledVrsta
            // 
            this.btnPregledVrsta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPregledVrsta.FlatAppearance.BorderSize = 0;
            this.btnPregledVrsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledVrsta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledVrsta.ForeColor = System.Drawing.Color.White;
            this.btnPregledVrsta.Location = new System.Drawing.Point(637, 253);
            this.btnPregledVrsta.Name = "btnPregledVrsta";
            this.btnPregledVrsta.Size = new System.Drawing.Size(202, 52);
            this.btnPregledVrsta.TabIndex = 7;
            this.btnPregledVrsta.Text = "Klikni";
            this.btnPregledVrsta.UseVisualStyleBackColor = false;
            this.btnPregledVrsta.Click += new System.EventHandler(this.btnPregledVrsta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vrste događaja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Bilten.WinUI.Properties.Resources._72619;
            this.pictureBox1.Location = new System.Drawing.Point(19, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(632, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pregled svih vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(634, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dodaj novu vrstu";
            // 
            // VrsteCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajVrstu);
            this.Controls.Add(this.btnPregledVrsta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "VrsteCustomControl";
            this.Size = new System.Drawing.Size(1100, 649);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajVrstu;
        private System.Windows.Forms.Button btnPregledVrsta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
