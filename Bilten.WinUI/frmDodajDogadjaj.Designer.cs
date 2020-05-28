namespace Bilten.WinUI
{
    partial class frmDodajDogadjaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajDogadjaj));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.cmbVrste = new System.Windows.Forms.ComboBox();
            this.cmbOrgJedinice = new System.Windows.Forms.ComboBox();
            this.cmbPodOrgJedinice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.calDatumDogadaja = new System.Windows.Forms.DateTimePicker();
            this.calDatumPrijave = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrijavitelj = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(493, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Org. jedinica";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbKategorije.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(83, 210);
            this.cmbKategorije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(339, 37);
            this.cmbKategorije.TabIndex = 4;
            this.cmbKategorije.SelectedIndexChanged += new System.EventHandler(this.cmbKategorije_SelectedIndexChanged);
            // 
            // cmbVrste
            // 
            this.cmbVrste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVrste.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbVrste.FormattingEnabled = true;
            this.cmbVrste.Location = new System.Drawing.Point(498, 210);
            this.cmbVrste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVrste.Name = "cmbVrste";
            this.cmbVrste.Size = new System.Drawing.Size(483, 37);
            this.cmbVrste.TabIndex = 5;
            // 
            // cmbOrgJedinice
            // 
            this.cmbOrgJedinice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOrgJedinice.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbOrgJedinice.FormattingEnabled = true;
            this.cmbOrgJedinice.Location = new System.Drawing.Point(83, 335);
            this.cmbOrgJedinice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrgJedinice.Name = "cmbOrgJedinice";
            this.cmbOrgJedinice.Size = new System.Drawing.Size(339, 37);
            this.cmbOrgJedinice.TabIndex = 6;
            this.cmbOrgJedinice.SelectedIndexChanged += new System.EventHandler(this.cmbOrgJedinice_SelectedIndexChanged);
            // 
            // cmbPodOrgJedinice
            // 
            this.cmbPodOrgJedinice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPodOrgJedinice.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbPodOrgJedinice.FormattingEnabled = true;
            this.cmbPodOrgJedinice.Location = new System.Drawing.Point(603, 335);
            this.cmbPodOrgJedinice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPodOrgJedinice.Name = "cmbPodOrgJedinice";
            this.cmbPodOrgJedinice.Size = new System.Drawing.Size(378, 37);
            this.cmbPodOrgJedinice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(600, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mjesto događaja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(78, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum događaja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(599, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Datum prijave";
            // 
            // txtMjesto
            // 
            this.txtMjesto.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtMjesto.Location = new System.Drawing.Point(603, 458);
            this.txtMjesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(378, 37);
            this.txtMjesto.TabIndex = 11;
            // 
            // calDatumDogadaja
            // 
            this.calDatumDogadaja.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calDatumDogadaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDatumDogadaja.Location = new System.Drawing.Point(83, 578);
            this.calDatumDogadaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calDatumDogadaja.Name = "calDatumDogadaja";
            this.calDatumDogadaja.Size = new System.Drawing.Size(339, 37);
            this.calDatumDogadaja.TabIndex = 12;
            // 
            // calDatumPrijave
            // 
            this.calDatumPrijave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calDatumPrijave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDatumPrijave.Location = new System.Drawing.Point(605, 578);
            this.calDatumPrijave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calDatumPrijave.Name = "calDatumPrijave";
            this.calDatumPrijave.Size = new System.Drawing.Size(376, 37);
            this.calDatumPrijave.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(77, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prijavitelj";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(78, 680);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kratki opis događaja";
            // 
            // txtPrijavitelj
            // 
            this.txtPrijavitelj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrijavitelj.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrijavitelj.Location = new System.Drawing.Point(83, 459);
            this.txtPrijavitelj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrijavitelj.Name = "txtPrijavitelj";
            this.txtPrijavitelj.Size = new System.Drawing.Size(339, 37);
            this.txtPrijavitelj.TabIndex = 17;
            // 
            // txtOpis
            // 
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpis.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtOpis.Location = new System.Drawing.Point(82, 720);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(899, 37);
            this.txtOpis.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 59);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dodaj novi događaj";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSnimi.FlatAppearance.BorderSize = 0;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(1588, 879);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(201, 55);
            this.btnSnimi.TabIndex = 21;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
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
            this.panel1.Size = new System.Drawing.Size(1833, 13);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2002, 3);
            this.panel3.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bilten.WinUI.Properties.Resources._122;
            this.pictureBox1.Location = new System.Drawing.Point(1606, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(555, 29);
            this.label11.TabIndex = 42;
            this.label11.Text = "Dodavanje novog prijavljenog događaja u Policijski bilten.";
            // 
            // txtLong
            // 
            this.txtLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLong.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtLong.Location = new System.Drawing.Point(1513, 794);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(308, 37);
            this.txtLong.TabIndex = 43;
            this.txtLong.Visible = false;
            // 
            // txtLat
            // 
            this.txtLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLat.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtLat.Location = new System.Drawing.Point(1105, 794);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(287, 37);
            this.txtLat.TabIndex = 44;
            this.txtLat.Visible = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(1054, 210);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(735, 547);
            this.map.TabIndex = 46;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1049, 796);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 29);
            this.label12.TabIndex = 47;
            this.label12.Text = "Lat:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1445, 798);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 29);
            this.label13.TabIndex = 48;
            this.label13.Text = "Long:";
            this.label13.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1105, 849);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(716, 37);
            this.textBox1.TabIndex = 50;
            this.textBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 1032);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1833, 13);
            this.panel2.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(598, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podorg. jedinica";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1049, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(373, 29);
            this.label14.TabIndex = 52;
            this.label14.Text = "Tačna lokacija prijavljenog događaja";
            // 
            // frmDodajDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1833, 1045);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.map);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtPrijavitelj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calDatumPrijave);
            this.Controls.Add(this.calDatumDogadaja);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPodOrgJedinice);
            this.Controls.Add(this.cmbOrgJedinice);
            this.Controls.Add(this.cmbVrste);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDodajDogadjaj";
            this.Text = "Novi događaj";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDodajDogadjaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.ComboBox cmbVrste;
        private System.Windows.Forms.ComboBox cmbOrgJedinice;
        private System.Windows.Forms.ComboBox cmbPodOrgJedinice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.DateTimePicker calDatumDogadaja;
        private System.Windows.Forms.DateTimePicker calDatumPrijave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrijavitelj;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
    }
}