﻿namespace Bilten.WinUI
{
    partial class frmFaceDetectionRecognition
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
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDodajOsobuSlike = new System.Windows.Forms.Button();
            this.btnOsobe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(12, 12);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(312, 241);
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(249, 270);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDodajOsobuSlike
            // 
            this.btnDodajOsobuSlike.Location = new System.Drawing.Point(349, 13);
            this.btnDodajOsobuSlike.Name = "btnDodajOsobuSlike";
            this.btnDodajOsobuSlike.Size = new System.Drawing.Size(75, 23);
            this.btnDodajOsobuSlike.TabIndex = 4;
            this.btnDodajOsobuSlike.Text = "OsobaSlike";
            this.btnDodajOsobuSlike.UseVisualStyleBackColor = true;
            this.btnDodajOsobuSlike.Click += new System.EventHandler(this.btnDodajOsobuSlike_Click);
            // 
            // btnOsobe
            // 
            this.btnOsobe.Location = new System.Drawing.Point(349, 66);
            this.btnOsobe.Name = "btnOsobe";
            this.btnOsobe.Size = new System.Drawing.Size(75, 23);
            this.btnOsobe.TabIndex = 5;
            this.btnOsobe.Text = "Osobe";
            this.btnOsobe.UseVisualStyleBackColor = true;
            this.btnOsobe.Click += new System.EventHandler(this.btnOsobe_Click);
            // 
            // frmFaceDetectionRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.btnOsobe);
            this.Controls.Add(this.btnDodajOsobuSlike);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.CamImageBox);
            this.Name = "frmFaceDetectionRecognition";
            this.Text = "frmFaceDetectionRecognition";
            this.Load += new System.EventHandler(this.frmFaceDetectionRecognition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDodajOsobuSlike;
        private System.Windows.Forms.Button btnOsobe;
    }
}