namespace Bilten.WinUI
{
    partial class frmGoogleMapaDogadjaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoogleMapaDogadjaja));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterSaobracaj = new System.Windows.Forms.Button();
            this.btnFilterKriminal = new System.Windows.Forms.Button();
            this.btnFilterNJRIM = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picTerrain = new System.Windows.Forms.PictureBox();
            this.picSatellite = new System.Windows.Forms.PictureBox();
            this.picNormal = new System.Windows.Forms.PictureBox();
            this.picHybrid = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSviDogadjaji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTerrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSatellite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHybrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(303, 100);
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
            this.map.Size = new System.Drawing.Size(1345, 775);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            this.map.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.map_OnMarkerDoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Bilten.WinUI.Properties.Resources.police_car_png_background_image_png_arts_police_car_png_transparent_background_450_340;
            this.pictureBox3.Location = new System.Drawing.Point(85, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bilten.WinUI.Properties.Resources.crime_scene_png_hd_police_tape_png_1600;
            this.pictureBox1.Location = new System.Drawing.Point(85, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Bilten.WinUI.Properties.Resources.handcuffs_transparent_png_clip_art_gallery_yopriceville_high_quality_images_and_transparent_33;
            this.pictureBox2.Location = new System.Drawing.Point(75, 486);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2081, 3);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(829, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mapa prijavljenih događaja";
            // 
            // btnFilterSaobracaj
            // 
            this.btnFilterSaobracaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFilterSaobracaj.FlatAppearance.BorderSize = 0;
            this.btnFilterSaobracaj.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilterSaobracaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSaobracaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSaobracaj.ForeColor = System.Drawing.Color.White;
            this.btnFilterSaobracaj.Location = new System.Drawing.Point(70, 193);
            this.btnFilterSaobracaj.Name = "btnFilterSaobracaj";
            this.btnFilterSaobracaj.Size = new System.Drawing.Size(153, 41);
            this.btnFilterSaobracaj.TabIndex = 20;
            this.btnFilterSaobracaj.Text = "Saobraćaj";
            this.btnFilterSaobracaj.UseVisualStyleBackColor = false;
            this.btnFilterSaobracaj.Click += new System.EventHandler(this.btnFilterSaobracaj_Click);
            // 
            // btnFilterKriminal
            // 
            this.btnFilterKriminal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFilterKriminal.FlatAppearance.BorderSize = 0;
            this.btnFilterKriminal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilterKriminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterKriminal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterKriminal.ForeColor = System.Drawing.Color.White;
            this.btnFilterKriminal.Location = new System.Drawing.Point(70, 378);
            this.btnFilterKriminal.Name = "btnFilterKriminal";
            this.btnFilterKriminal.Size = new System.Drawing.Size(153, 41);
            this.btnFilterKriminal.TabIndex = 21;
            this.btnFilterKriminal.Text = "Kriminal";
            this.btnFilterKriminal.UseVisualStyleBackColor = false;
            this.btnFilterKriminal.Click += new System.EventHandler(this.btnFilterKriminal_Click);
            // 
            // btnFilterNJRIM
            // 
            this.btnFilterNJRIM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFilterNJRIM.FlatAppearance.BorderSize = 0;
            this.btnFilterNJRIM.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilterNJRIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterNJRIM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterNJRIM.ForeColor = System.Drawing.Color.White;
            this.btnFilterNJRIM.Location = new System.Drawing.Point(65, 577);
            this.btnFilterNJRIM.Name = "btnFilterNJRIM";
            this.btnFilterNJRIM.Size = new System.Drawing.Size(153, 41);
            this.btnFilterNJRIM.TabIndex = 23;
            this.btnFilterNJRIM.Text = "NJRiM";
            this.btnFilterNJRIM.UseVisualStyleBackColor = false;
            this.btnFilterNJRIM.Click += new System.EventHandler(this.btnFilterNJRIM_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Bilten.WinUI.Properties.Resources.google_map_1772225_1507809;
            this.pictureBox4.Location = new System.Drawing.Point(783, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // picTerrain
            // 
            this.picTerrain.BackColor = System.Drawing.Color.Transparent;
            this.picTerrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTerrain.Image = global::Bilten.WinUI.Properties.Resources.worldwide;
            this.picTerrain.Location = new System.Drawing.Point(1746, 408);
            this.picTerrain.Name = "picTerrain";
            this.picTerrain.Size = new System.Drawing.Size(75, 70);
            this.picTerrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTerrain.TabIndex = 25;
            this.picTerrain.TabStop = false;
            this.picTerrain.Click += new System.EventHandler(this.picTerrain_Click);
            // 
            // picSatellite
            // 
            this.picSatellite.BackColor = System.Drawing.Color.Transparent;
            this.picSatellite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSatellite.Image = global::Bilten.WinUI.Properties.Resources.globe;
            this.picSatellite.Location = new System.Drawing.Point(1746, 250);
            this.picSatellite.Name = "picSatellite";
            this.picSatellite.Size = new System.Drawing.Size(75, 70);
            this.picSatellite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSatellite.TabIndex = 26;
            this.picSatellite.TabStop = false;
            this.picSatellite.Click += new System.EventHandler(this.picSatellite_Click);
            // 
            // picNormal
            // 
            this.picNormal.BackColor = System.Drawing.Color.Transparent;
            this.picNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNormal.Image = global::Bilten.WinUI.Properties.Resources.google_maps;
            this.picNormal.Location = new System.Drawing.Point(1746, 100);
            this.picNormal.Name = "picNormal";
            this.picNormal.Size = new System.Drawing.Size(75, 73);
            this.picNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNormal.TabIndex = 27;
            this.picNormal.TabStop = false;
            this.picNormal.Click += new System.EventHandler(this.picNormal_Click);
            // 
            // picHybrid
            // 
            this.picHybrid.BackColor = System.Drawing.Color.Transparent;
            this.picHybrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHybrid.Image = global::Bilten.WinUI.Properties.Resources.earth_globe;
            this.picHybrid.Location = new System.Drawing.Point(1746, 568);
            this.picHybrid.Name = "picHybrid";
            this.picHybrid.Size = new System.Drawing.Size(75, 70);
            this.picHybrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHybrid.TabIndex = 28;
            this.picHybrid.TabStop = false;
            this.picHybrid.Click += new System.EventHandler(this.picHybrid_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Bilten.WinUI.Properties.Resources._122;
            this.pictureBox5.Location = new System.Drawing.Point(75, 721);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(134, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // btnSviDogadjaji
            // 
            this.btnSviDogadjaji.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSviDogadjaji.FlatAppearance.BorderSize = 0;
            this.btnSviDogadjaji.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSviDogadjaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSviDogadjaji.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSviDogadjaji.ForeColor = System.Drawing.Color.White;
            this.btnSviDogadjaji.Location = new System.Drawing.Point(65, 803);
            this.btnSviDogadjaji.Name = "btnSviDogadjaji";
            this.btnSviDogadjaji.Size = new System.Drawing.Size(153, 41);
            this.btnSviDogadjaji.TabIndex = 30;
            this.btnSviDogadjaji.Text = "Svi događaji";
            this.btnSviDogadjaji.UseVisualStyleBackColor = false;
            this.btnSviDogadjaji.Click += new System.EventHandler(this.btnSviDogadjaji_Click);
            // 
            // btnFilterNJRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilten.WinUI.Properties.Resources.bekgraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1921, 935);
            this.Controls.Add(this.btnSviDogadjaji);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picHybrid);
            this.Controls.Add(this.picNormal);
            this.Controls.Add(this.picSatellite);
            this.Controls.Add(this.picTerrain);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnFilterNJRIM);
            this.Controls.Add(this.btnFilterKriminal);
            this.Controls.Add(this.btnFilterSaobracaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.map);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnFilterNJRM";
            this.Text = "Google mapa događaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGoogleMapaDogadjaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTerrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSatellite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHybrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterSaobracaj;
        private System.Windows.Forms.Button btnFilterKriminal;
        private System.Windows.Forms.Button btnFilterNJRIM;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picTerrain;
        private System.Windows.Forms.PictureBox picSatellite;
        private System.Windows.Forms.PictureBox picNormal;
        private System.Windows.Forms.PictureBox picHybrid;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnSviDogadjaji;
    }
}