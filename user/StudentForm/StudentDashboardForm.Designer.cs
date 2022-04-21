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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 180D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 180D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Pnd_TeacherInfo = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Lbl_TestSayisi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Btn_Logout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Lbl_Ad_Soyad = new System.Windows.Forms.Label();
            this.Lbl_SoruSayisi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Lbl_Eposta = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Lbl_KullaniciAdi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_Questions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_SinavOl = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Yazdir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnd_TeacherInfo)).BeginInit();
            this.Pnd_TeacherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_Questions)).BeginInit();
            this.Pnl_Questions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 25;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "DogruYanlis";
            dataPoint1.Color = System.Drawing.Color.LawnGreen;
            dataPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.Label = "Doğru";
            dataPoint1.LabelAngle = 0;
            dataPoint1.LabelFormat = "";
            dataPoint1.LegendText = "Doğru";
            dataPoint2.Color = System.Drawing.Color.Red;
            dataPoint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataPoint2.Label = "Yanlış";
            dataPoint2.LabelForeColor = System.Drawing.Color.Black;
            dataPoint2.LegendText = "Yanlış";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(349, 260);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Toplam Doğru - Yanlış Grafiği";
            this.chart1.Titles.Add(title1);
            // 
            // Pnd_TeacherInfo
            // 
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_TestSayisi);
            this.Pnd_TeacherInfo.Controls.Add(this.kryptonLabel2);
            this.Pnd_TeacherInfo.Controls.Add(this.Btn_Logout);
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_Ad_Soyad);
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_SoruSayisi);
            this.Pnd_TeacherInfo.Controls.Add(this.kryptonLabel3);
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_Eposta);
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_KullaniciAdi);
            this.Pnd_TeacherInfo.Controls.Add(this.pictureBox1);
            this.Pnd_TeacherInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnd_TeacherInfo.Location = new System.Drawing.Point(0, 0);
            this.Pnd_TeacherInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnd_TeacherInfo.MinimumSize = new System.Drawing.Size(238, 500);
            this.Pnd_TeacherInfo.Name = "Pnd_TeacherInfo";
            this.Pnd_TeacherInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Pnd_TeacherInfo.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.Pnd_TeacherInfo.Size = new System.Drawing.Size(238, 598);
            this.Pnd_TeacherInfo.StateCommon.Color1 = System.Drawing.Color.Cyan;
            this.Pnd_TeacherInfo.StateCommon.Color2 = System.Drawing.Color.Black;
            this.Pnd_TeacherInfo.TabIndex = 6;
            // 
            // Lbl_TestSayisi
            // 
            this.Lbl_TestSayisi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_TestSayisi.Location = new System.Drawing.Point(167, 353);
            this.Lbl_TestSayisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lbl_TestSayisi.Name = "Lbl_TestSayisi";
            this.Lbl_TestSayisi.Size = new System.Drawing.Size(93, 24);
            this.Lbl_TestSayisi.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_TestSayisi.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TestSayisi.TabIndex = 8;
            this.Lbl_TestSayisi.Values.Text = "Test_sayısı";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(14, 353);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(160, 24);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "Girdiğin test sayısı :";
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Logout.Location = new System.Drawing.Point(9, 555);
            this.Btn_Logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.Btn_Logout.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.Btn_Logout.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Logout.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Logout.Size = new System.Drawing.Size(107, 33);
            this.Btn_Logout.StateCommon.Back.Color1 = System.Drawing.Color.Firebrick;
            this.Btn_Logout.StateCommon.Back.Color2 = System.Drawing.Color.Firebrick;
            this.Btn_Logout.StateCommon.Border.Color1 = System.Drawing.Color.Firebrick;
            this.Btn_Logout.StateCommon.Border.Color2 = System.Drawing.Color.Firebrick;
            this.Btn_Logout.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Logout.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Logout.StateCommon.Border.Rounding = 5;
            this.Btn_Logout.StateCommon.Border.Width = 2;
            this.Btn_Logout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Logout.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Logout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Logout.StatePressed.Back.Color1 = System.Drawing.Color.Tomato;
            this.Btn_Logout.StatePressed.Back.Color2 = System.Drawing.Color.Tomato;
            this.Btn_Logout.StatePressed.Border.Color1 = System.Drawing.Color.Tomato;
            this.Btn_Logout.StatePressed.Border.Color2 = System.Drawing.Color.Tomato;
            this.Btn_Logout.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Logout.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Logout.StatePressed.Border.Rounding = 5;
            this.Btn_Logout.StatePressed.Border.Width = 2;
            this.Btn_Logout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Logout.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Logout.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Logout.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.Btn_Logout.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.Btn_Logout.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.Btn_Logout.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.Btn_Logout.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Logout.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Logout.StateTracking.Border.Rounding = 5;
            this.Btn_Logout.StateTracking.Border.Width = 2;
            this.Btn_Logout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Logout.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Logout.TabIndex = 4;
            this.Btn_Logout.Values.Text = "ÇIKIŞ";
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Lbl_Ad_Soyad
            // 
            this.Lbl_Ad_Soyad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Ad_Soyad.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_Ad_Soyad.ForeColor = System.Drawing.Color.White;
            this.Lbl_Ad_Soyad.Location = new System.Drawing.Point(9, 181);
            this.Lbl_Ad_Soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Ad_Soyad.Name = "Lbl_Ad_Soyad";
            this.Lbl_Ad_Soyad.Size = new System.Drawing.Size(224, 37);
            this.Lbl_Ad_Soyad.TabIndex = 6;
            this.Lbl_Ad_Soyad.Text = "Ad_Soyad";
            this.Lbl_Ad_Soyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SoruSayisi
            // 
            this.Lbl_SoruSayisi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_SoruSayisi.Location = new System.Drawing.Point(176, 324);
            this.Lbl_SoruSayisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lbl_SoruSayisi.Name = "Lbl_SoruSayisi";
            this.Lbl_SoruSayisi.Size = new System.Drawing.Size(82, 24);
            this.Lbl_SoruSayisi.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_SoruSayisi.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SoruSayisi.TabIndex = 5;
            this.Lbl_SoruSayisi.Values.Text = "Soru Sayı";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(14, 324);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(171, 24);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Çözdüğün soru sayısı :";
            // 
            // Lbl_Eposta
            // 
            this.Lbl_Eposta.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_Eposta.Location = new System.Drawing.Point(22, 276);
            this.Lbl_Eposta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lbl_Eposta.Name = "Lbl_Eposta";
            this.Lbl_Eposta.Size = new System.Drawing.Size(59, 24);
            this.Lbl_Eposta.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_Eposta.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Eposta.TabIndex = 3;
            this.Lbl_Eposta.Values.Text = "Eposta";
            // 
            // Lbl_KullaniciAdi
            // 
            this.Lbl_KullaniciAdi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_KullaniciAdi.Location = new System.Drawing.Point(22, 234);
            this.Lbl_KullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lbl_KullaniciAdi.Name = "Lbl_KullaniciAdi";
            this.Lbl_KullaniciAdi.Size = new System.Drawing.Size(101, 24);
            this.Lbl_KullaniciAdi.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_KullaniciAdi.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KullaniciAdi.TabIndex = 2;
            this.Lbl_KullaniciAdi.Values.Text = "Kullanıcı_Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pnl_Questions
            // 
            this.Pnl_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Questions.AutoScroll = true;
            this.Pnl_Questions.Controls.Add(this.btn_Yazdir);
            this.Pnl_Questions.Controls.Add(this.chart2);
            this.Pnl_Questions.Controls.Add(this.chart1);
            this.Pnl_Questions.Location = new System.Drawing.Point(238, 0);
            this.Pnl_Questions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Questions.Name = "Pnl_Questions";
            this.Pnl_Questions.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighInternalProfile;
            this.Pnl_Questions.Size = new System.Drawing.Size(727, 550);
            this.Pnl_Questions.StateCommon.Color1 = System.Drawing.Color.White;
            this.Pnl_Questions.StateCommon.Color2 = System.Drawing.Color.Cyan;
            this.Pnl_Questions.TabIndex = 7;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.btn_SinavOl);
            this.kryptonPanel2.Location = new System.Drawing.Point(433, 550);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(532, 48);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Cyan;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 8;
            // 
            // btn_SinavOl
            // 
            this.btn_SinavOl.Location = new System.Drawing.Point(416, 10);
            this.btn_SinavOl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SinavOl.Name = "btn_SinavOl";
            this.btn_SinavOl.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_SinavOl.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_SinavOl.Size = new System.Drawing.Size(107, 33);
            this.btn_SinavOl.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_SinavOl.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_SinavOl.StateCommon.Border.Rounding = 10;
            this.btn_SinavOl.StateCommon.Border.Width = 2;
            this.btn_SinavOl.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_SinavOl.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_SinavOl.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SinavOl.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.btn_SinavOl.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.btn_SinavOl.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.btn_SinavOl.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.btn_SinavOl.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_SinavOl.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_SinavOl.StatePressed.Border.Rounding = 10;
            this.btn_SinavOl.StatePressed.Border.Width = 2;
            this.btn_SinavOl.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_SinavOl.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_SinavOl.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SinavOl.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.btn_SinavOl.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.btn_SinavOl.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.btn_SinavOl.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.btn_SinavOl.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_SinavOl.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_SinavOl.StateTracking.Border.Rounding = 10;
            this.btn_SinavOl.StateTracking.Border.Width = 2;
            this.btn_SinavOl.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_SinavOl.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_SinavOl.TabIndex = 0;
            this.btn_SinavOl.Values.Text = "SINAV OL";
            this.btn_SinavOl.Click += new System.EventHandler(this.btn_SinavOl_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.CursorY.LineColor = System.Drawing.Color.DarkRed;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(271, 108);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Color = System.Drawing.Color.Lime;
            series2.EmptyPointStyle.Label = "asdasd";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series2.IsXValueIndexed = true;
            series2.Label = "#VAL{N0}";
            series2.Legend = "Legend1";
            series2.Name = "DogruSayisi";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series3.Color = System.Drawing.Color.Red;
            series3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            series3.Label = "#VAL";
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "YanlisSayisi";
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(456, 439);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.Location = new System.Drawing.Point(611, 467);
            this.btn_Yazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.btn_Yazdir.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.btn_Yazdir.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Yazdir.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Yazdir.Size = new System.Drawing.Size(105, 42);
            this.btn_Yazdir.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.btn_Yazdir.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.btn_Yazdir.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.btn_Yazdir.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.btn_Yazdir.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Yazdir.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Yazdir.StateCommon.Border.Rounding = 10;
            this.btn_Yazdir.StateCommon.Border.Width = 2;
            this.btn_Yazdir.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Yazdir.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Yazdir.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yazdir.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.btn_Yazdir.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.btn_Yazdir.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.btn_Yazdir.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.btn_Yazdir.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Yazdir.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Yazdir.StatePressed.Border.Rounding = 10;
            this.btn_Yazdir.StatePressed.Border.Width = 2;
            this.btn_Yazdir.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Yazdir.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Yazdir.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yazdir.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.btn_Yazdir.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.btn_Yazdir.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.btn_Yazdir.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.btn_Yazdir.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Yazdir.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Yazdir.StateTracking.Border.Rounding = 10;
            this.btn_Yazdir.StateTracking.Border.Width = 2;
            this.btn_Yazdir.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Yazdir.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Yazdir.TabIndex = 1;
            this.btn_Yazdir.Values.Text = "YAZDIR";
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // StudentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.Pnd_TeacherInfo);
            this.Controls.Add(this.Pnl_Questions);
            this.Controls.Add(this.kryptonPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentDashboardForm";
            this.Text = "StudentDashboardForm";
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnd_TeacherInfo)).EndInit();
            this.Pnd_TeacherInfo.ResumeLayout(false);
            this.Pnd_TeacherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_Questions)).EndInit();
            this.Pnl_Questions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel Pnd_TeacherInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Logout;
        private System.Windows.Forms.Label Lbl_Ad_Soyad;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_SoruSayisi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_Eposta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_KullaniciAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel Pnl_Questions;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_SinavOl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_TestSayisi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Yazdir;
    }
}