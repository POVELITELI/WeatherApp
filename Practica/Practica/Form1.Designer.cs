namespace Practica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.elipseControlArtan1 = new ElipseArtanAcademy1.ElipseControlArtan();
            this.btn_close = new ArtanButton.ArtanButton();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.lab_deg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_temp_max = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_temp_min = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_detail = new System.Windows.Forms.Label();
            this.label_text3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_condition = new System.Windows.Forms.Label();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.btn_search = new ArtanButton.ArtanButton();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseControlArtan1
            // 
            this.elipseControlArtan1.CornerRadius = 25;
            this.elipseControlArtan1.TargetControl = this;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_close.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_close.BorderRadius = 20;
            this.btn_close.BorderSize = 0;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(931, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(41, 36);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = " X";
            this.btn_close.TextColor = System.Drawing.Color.White;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.artanButton1_Click);
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.lab_deg);
            this.artanPanel1.Controls.Add(this.label5);
            this.artanPanel1.Controls.Add(this.lab_temp_max);
            this.artanPanel1.Controls.Add(this.label4);
            this.artanPanel1.Controls.Add(this.lab_temp_min);
            this.artanPanel1.Controls.Add(this.label2);
            this.artanPanel1.Controls.Add(this.label_country);
            this.artanPanel1.Controls.Add(this.lab_pressure);
            this.artanPanel1.Controls.Add(this.lab_windspeed);
            this.artanPanel1.Controls.Add(this.label9);
            this.artanPanel1.Controls.Add(this.label8);
            this.artanPanel1.Controls.Add(this.lab_sunset);
            this.artanPanel1.Controls.Add(this.lab_sunrise);
            this.artanPanel1.Controls.Add(this.lab_detail);
            this.artanPanel1.Controls.Add(this.label_text3);
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.Controls.Add(this.lab_condition);
            this.artanPanel1.Controls.Add(this.artanPanel2);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.Transparent;
            this.artanPanel1.Location = new System.Drawing.Point(127, 115);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(723, 361);
            this.artanPanel1.TabIndex = 1;
            // 
            // lab_deg
            // 
            this.lab_deg.AutoSize = true;
            this.lab_deg.BackColor = System.Drawing.Color.Transparent;
            this.lab_deg.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_deg.ForeColor = System.Drawing.Color.White;
            this.lab_deg.Location = new System.Drawing.Point(273, 287);
            this.lab_deg.Name = "lab_deg";
            this.lab_deg.Size = new System.Drawing.Size(72, 48);
            this.lab_deg.TabIndex = 20;
            this.lab_deg.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 48);
            this.label5.TabIndex = 19;
            this.label5.Text = "Directia vantului:";
            // 
            // lab_temp_max
            // 
            this.lab_temp_max.AutoSize = true;
            this.lab_temp_max.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp_max.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temp_max.ForeColor = System.Drawing.Color.White;
            this.lab_temp_max.Location = new System.Drawing.Point(534, 287);
            this.lab_temp_max.Name = "lab_temp_max";
            this.lab_temp_max.Size = new System.Drawing.Size(72, 48);
            this.lab_temp_max.TabIndex = 18;
            this.lab_temp_max.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 48);
            this.label4.TabIndex = 17;
            this.label4.Text = "Temp max:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab_temp_min
            // 
            this.lab_temp_min.AutoSize = true;
            this.lab_temp_min.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp_min.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temp_min.ForeColor = System.Drawing.Color.White;
            this.lab_temp_min.Location = new System.Drawing.Point(534, 239);
            this.lab_temp_min.Name = "lab_temp_min";
            this.lab_temp_min.Size = new System.Drawing.Size(72, 48);
            this.lab_temp_min.TabIndex = 16;
            this.lab_temp_min.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(372, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 48);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temp min:";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.BackColor = System.Drawing.Color.Transparent;
            this.label_country.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_country.ForeColor = System.Drawing.Color.White;
            this.label_country.Location = new System.Drawing.Point(45, 97);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(118, 48);
            this.label_country.TabIndex = 14;
            this.label_country.Text = "<Țara>";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(531, 191);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(72, 48);
            this.lab_pressure.TabIndex = 13;
            this.lab_pressure.Text = "N/A";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeed.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_windspeed.ForeColor = System.Drawing.Color.White;
            this.lab_windspeed.Location = new System.Drawing.Point(270, 239);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(72, 48);
            this.lab_windspeed.TabIndex = 12;
            this.lab_windspeed.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(372, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 48);
            this.label9.TabIndex = 11;
            this.label9.Text = "Presiune:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 48);
            this.label8.TabIndex = 10;
            this.label8.Text = "Viteza vantului:";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.ForeColor = System.Drawing.Color.White;
            this.lab_sunset.Location = new System.Drawing.Point(367, 145);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(72, 48);
            this.lab_sunset.TabIndex = 9;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.ForeColor = System.Drawing.Color.White;
            this.lab_sunrise.Location = new System.Drawing.Point(367, 97);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(72, 48);
            this.lab_sunrise.TabIndex = 8;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.BackColor = System.Drawing.Color.Transparent;
            this.lab_detail.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_detail.ForeColor = System.Drawing.Color.White;
            this.lab_detail.Location = new System.Drawing.Point(45, 191);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(143, 48);
            this.lab_detail.TabIndex = 7;
            this.lab_detail.Text = "<Detalii>";
            // 
            // label_text3
            // 
            this.label_text3.AutoSize = true;
            this.label_text3.BackColor = System.Drawing.Color.Transparent;
            this.label_text3.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text3.ForeColor = System.Drawing.Color.White;
            this.label_text3.Location = new System.Drawing.Point(254, 97);
            this.label_text3.Name = "label_text3";
            this.label_text3.Size = new System.Drawing.Size(117, 48);
            this.label_text3.TabIndex = 6;
            this.label_text3.Text = "Rasarit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apus:";
            // 
            // lab_condition
            // 
            this.lab_condition.AutoSize = true;
            this.lab_condition.BackColor = System.Drawing.Color.Transparent;
            this.lab_condition.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_condition.ForeColor = System.Drawing.Color.White;
            this.lab_condition.Location = new System.Drawing.Point(45, 145);
            this.lab_condition.Name = "lab_condition";
            this.lab_condition.Size = new System.Drawing.Size(158, 48);
            this.lab_condition.TabIndex = 4;
            this.lab_condition.Text = "<Condiții>";
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 30;
            this.artanPanel2.Controls.Add(this.label1);
            this.artanPanel2.Controls.Add(this.TbCity);
            this.artanPanel2.Controls.Add(this.btn_search);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.artanPanel2.Location = new System.Drawing.Point(0, 0);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(723, 70);
            this.artanPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "City:";
            // 
            // TbCity
            // 
            this.TbCity.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.TbCity.Location = new System.Drawing.Point(232, 13);
            this.TbCity.Multiline = true;
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(262, 36);
            this.TbCity.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.BackgroundColor = System.Drawing.Color.White;
            this.btn_search.BorderRadius = 20;
            this.btn_search.BorderSize = 0;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_search.Location = new System.Drawing.Point(530, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 36);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.TextColor = System.Drawing.Color.SteelBlue;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 647);
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ElipseArtanAcademy1.ElipseControlArtan elipseControlArtan1;
        private ArtanButton.ArtanButton btn_close;
        private ArtanComponent.ArtanPanel artanPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCity;
        private ArtanButton.ArtanButton btn_search;
        private ArtanComponent.ArtanPanel artanPanel2;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label label_text3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_condition;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_temp_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_deg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_temp_max;
    }
}

