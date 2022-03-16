namespace Question_Answer.user.StudentUserForm
{
    partial class StudentDashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 180D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 180D);
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Eposta = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SinavOl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 25;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 33);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "DogruYanlisBos";
            dataPoint5.Color = System.Drawing.Color.LawnGreen;
            dataPoint5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataPoint5.IsValueShownAsLabel = false;
            dataPoint5.Label = "Doğru";
            dataPoint5.LabelAngle = 0;
            dataPoint5.LabelFormat = "";
            dataPoint5.LegendText = "Doğru";
            dataPoint6.Color = System.Drawing.Color.Red;
            dataPoint6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataPoint6.Label = "Yanlış";
            dataPoint6.LabelForeColor = System.Drawing.Color.Black;
            dataPoint6.LegendText = "Yanlış";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(429, 283);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title1";
            title3.Text = "Toplam Doğru - Yanlış Grafiği";
            this.chart1.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_KullaniciAdi);
            this.panel1.Controls.Add(this.lbl_Eposta);
            this.panel1.Controls.Add(this.lbl_Soyad);
            this.panel1.Controls.Add(this.lbl_Ad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(601, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 272);
            this.panel1.TabIndex = 1;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(164, 157);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(0, 25);
            this.lbl_KullaniciAdi.TabIndex = 7;
            // 
            // lbl_Eposta
            // 
            this.lbl_Eposta.AutoSize = true;
            this.lbl_Eposta.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Eposta.Location = new System.Drawing.Point(164, 199);
            this.lbl_Eposta.Name = "lbl_Eposta";
            this.lbl_Eposta.Size = new System.Drawing.Size(0, 25);
            this.lbl_Eposta.TabIndex = 6;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Soyad.Location = new System.Drawing.Point(164, 112);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(0, 25);
            this.lbl_Soyad.TabIndex = 5;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Ad.Location = new System.Drawing.Point(164, 67);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(0, 25);
            this.lbl_Ad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kullancı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Eposta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(634, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Hesap Bilgileri";
            // 
            // btn_SinavOl
            // 
            this.btn_SinavOl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SinavOl.BackColor = System.Drawing.Color.Lime;
            this.btn_SinavOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SinavOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SinavOl.Location = new System.Drawing.Point(12, 398);
            this.btn_SinavOl.Name = "btn_SinavOl";
            this.btn_SinavOl.Size = new System.Drawing.Size(193, 63);
            this.btn_SinavOl.TabIndex = 3;
            this.btn_SinavOl.Text = "Sınav Ol";
            this.btn_SinavOl.UseVisualStyleBackColor = false;
            this.btn_SinavOl.Click += new System.EventHandler(this.btn_SinavOl_Click);
            // 
            // StudentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1028, 473);
            this.Controls.Add(this.btn_SinavOl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "StudentDashboardForm";
            this.Text = "StudentDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Eposta;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SinavOl;
    }
}