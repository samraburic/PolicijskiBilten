namespace Bilten.WinUI
{
    partial class frmVozilaSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVozilaSearch));
            this.txtBrRegOznake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziVozila = new System.Windows.Forms.Button();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrRegOznake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrRegOznake
            // 
            this.txtBrRegOznake.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrRegOznake.Location = new System.Drawing.Point(13, 111);
            this.txtBrRegOznake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBrRegOznake.Name = "txtBrRegOznake";
            this.txtBrRegOznake.Size = new System.Drawing.Size(300, 37);
            this.txtBrRegOznake.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj registarske oznake";
            // 
            // btnPrikaziVozila
            // 
            this.btnPrikaziVozila.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrikaziVozila.FlatAppearance.BorderSize = 0;
            this.btnPrikaziVozila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziVozila.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziVozila.ForeColor = System.Drawing.Color.White;
            this.btnPrikaziVozila.Location = new System.Drawing.Point(346, 111);
            this.btnPrikaziVozila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrikaziVozila.Name = "btnPrikaziVozila";
            this.btnPrikaziVozila.Size = new System.Drawing.Size(121, 37);
            this.btnPrikaziVozila.TabIndex = 2;
            this.btnPrikaziVozila.Text = "Prikaži";
            this.btnPrikaziVozila.UseVisualStyleBackColor = false;
            this.btnPrikaziVozila.Click += new System.EventHandler(this.btnPrikaziVozila_Click);
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozila.BackgroundColor = System.Drawing.Color.White;
            this.dgvVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVozila.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVozila.ColumnHeadersHeight = 40;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Marka,
            this.Model,
            this.BrRegOznake});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVozila.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVozila.EnableHeadersVisualStyles = false;
            this.dgvVozila.GridColor = System.Drawing.Color.Silver;
            this.dgvVozila.Location = new System.Drawing.Point(13, 173);
            this.dgvVozila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowHeadersVisible = false;
            this.dgvVozila.RowHeadersWidth = 62;
            this.dgvVozila.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvVozila.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVozila.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVozila.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvVozila.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvVozila.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvVozila.RowTemplate.DividerHeight = 1;
            this.dgvVozila.RowTemplate.Height = 38;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(991, 507);
            this.dgvVozila.TabIndex = 3;
            this.dgvVozila.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozila_CellClick);
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
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 8;
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 8;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // BrRegOznake
            // 
            this.BrRegOznake.DataPropertyName = "BrRegOznake";
            this.BrRegOznake.HeaderText = "Broj reg. oznake";
            this.BrRegOznake.MinimumWidth = 8;
            this.BrRegOznake.Name = "BrRegOznake";
            this.BrRegOznake.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registar vozila";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Bilten.WinUI.Properties.Resources._2018_audi_a6_premium_20_tfsi_32_white;
            this.pictureBox2.Location = new System.Drawing.Point(707, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // frmVozilaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 694);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.btnPrikaziVozila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrRegOznake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVozilaSearch";
            this.Text = "Registar vozila - Dodaj vozilo";
            this.Load += new System.EventHandler(this.frmVozilaSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrRegOznake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaziVozila;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrRegOznake;
    }
}