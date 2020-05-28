namespace Bilten.WinUI
{
    partial class frmPodorganizacionaJedinica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPodorganizacionaJedinica));
            this.btnDodajPodorgJed = new System.Windows.Forms.Button();
            this.dgvPodorganizacioneJedinice = new System.Windows.Forms.DataGridView();
            this.cmbOrganizacionaJedinica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodorganizacioneJedinice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajPodorgJed
            // 
            this.btnDodajPodorgJed.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajPodorgJed.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnDodajPodorgJed.FlatAppearance.BorderSize = 3;
            this.btnDodajPodorgJed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPodorgJed.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPodorgJed.ForeColor = System.Drawing.Color.White;
            this.btnDodajPodorgJed.Location = new System.Drawing.Point(394, 579);
            this.btnDodajPodorgJed.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDodajPodorgJed.Name = "btnDodajPodorgJed";
            this.btnDodajPodorgJed.Size = new System.Drawing.Size(218, 60);
            this.btnDodajPodorgJed.TabIndex = 3;
            this.btnDodajPodorgJed.Text = "Dodaj novu";
            this.btnDodajPodorgJed.UseVisualStyleBackColor = false;
            this.btnDodajPodorgJed.Click += new System.EventHandler(this.btnDodajPodorgJed_Click);
            // 
            // dgvPodorganizacioneJedinice
            // 
            this.dgvPodorganizacioneJedinice.AllowUserToAddRows = false;
            this.dgvPodorganizacioneJedinice.AllowUserToDeleteRows = false;
            this.dgvPodorganizacioneJedinice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPodorganizacioneJedinice.BackgroundColor = System.Drawing.Color.White;
            this.dgvPodorganizacioneJedinice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPodorganizacioneJedinice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPodorganizacioneJedinice.ColumnHeadersHeight = 45;
            this.dgvPodorganizacioneJedinice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPodorganizacioneJedinice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPodorganizacioneJedinice.Location = new System.Drawing.Point(105, 262);
            this.dgvPodorganizacioneJedinice.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dgvPodorganizacioneJedinice.Name = "dgvPodorganizacioneJedinice";
            this.dgvPodorganizacioneJedinice.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPodorganizacioneJedinice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPodorganizacioneJedinice.RowHeadersVisible = false;
            this.dgvPodorganizacioneJedinice.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvPodorganizacioneJedinice.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPodorganizacioneJedinice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPodorganizacioneJedinice.Size = new System.Drawing.Size(507, 278);
            this.dgvPodorganizacioneJedinice.TabIndex = 2;
            this.dgvPodorganizacioneJedinice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPodorganizacioneJedinice_CellDoubleClick);
            // 
            // cmbOrganizacionaJedinica
            // 
            this.cmbOrganizacionaJedinica.FormattingEnabled = true;
            this.cmbOrganizacionaJedinica.Location = new System.Drawing.Point(373, 199);
            this.cmbOrganizacionaJedinica.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cmbOrganizacionaJedinica.Name = "cmbOrganizacionaJedinica";
            this.cmbOrganizacionaJedinica.Size = new System.Drawing.Size(239, 37);
            this.cmbOrganizacionaJedinica.TabIndex = 1;
            this.cmbOrganizacionaJedinica.SelectedIndexChanged += new System.EventHandler(this.cmbOrganizacionaJedinica_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organizaciona jedinica:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(18, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 3);
            this.panel3.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pregled i prikaz svih podorganizacionih jedinica.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 49);
            this.label2.TabIndex = 38;
            this.label2.Text = "Podorganizacione jedinice";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 15);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bilten.WinUI.Properties.Resources.birthday_and_party__2_;
            this.pictureBox1.Location = new System.Drawing.Point(549, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
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
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 8;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // frmPodorganizacionaJedinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajPodorgJed);
            this.Controls.Add(this.dgvPodorganizacioneJedinice);
            this.Controls.Add(this.cmbOrganizacionaJedinica);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frmPodorganizacionaJedinica";
            this.Text = "Podorganizacione jedinice";
            this.Load += new System.EventHandler(this.frmPodorganizacionaJedinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodorganizacioneJedinice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPodorganizacioneJedinice;
        private System.Windows.Forms.ComboBox cmbOrganizacionaJedinica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPodorgJed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}