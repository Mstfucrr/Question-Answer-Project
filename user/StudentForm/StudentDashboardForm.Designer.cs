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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 180D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 180D);
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboardForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Pnd_TeacherInfo = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Btn_Logout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Lbl_Ad_Soyad = new System.Windows.Forms.Label();
            this.Lbl_SoruSayisi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Lbl_Eposta = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Lbl_KullaniciAdi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_Questions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Btn_added_question = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_SinavOl = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Lbl_TestSayisi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnd_TeacherInfo)).BeginInit();
            this.Pnd_TeacherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_Questions)).BeginInit();
            this.Pnl_Questions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Area3DStyle.Inclination = 25;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "DogruYanlisBos";
            dataPoint7.Color = System.Drawing.Color.LawnGreen;
            dataPoint7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataPoint7.IsValueShownAsLabel = false;
            dataPoint7.Label = "Doğru";
            dataPoint7.LabelAngle = 0;
            dataPoint7.LabelFormat = "";
            dataPoint7.LegendText = "Doğru";
            dataPoint8.Color = System.Drawing.Color.Red;
            dataPoint8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataPoint8.Label = "Yanlış";
            dataPoint8.LabelForeColor = System.Drawing.Color.Black;
            dataPoint8.LegendText = "Yanlış";
            series4.Points.Add(dataPoint7);
            series4.Points.Add(dataPoint8);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(465, 320);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "Toplam Doğru - Yanlış Grafiği";
            this.chart1.Titles.Add(title4);
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
            this.Pnd_TeacherInfo.MinimumSize = new System.Drawing.Size(317, 615);
            this.Pnd_TeacherInfo.Name = "Pnd_TeacherInfo";
            this.Pnd_TeacherInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Pnd_TeacherInfo.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.Pnd_TeacherInfo.Size = new System.Drawing.Size(317, 697);
            this.Pnd_TeacherInfo.StateCommon.Color1 = System.Drawing.Color.Cyan;
            this.Pnd_TeacherInfo.StateCommon.Color2 = System.Drawing.Color.Black;
            this.Pnd_TeacherInfo.TabIndex = 6;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Logout.Location = new System.Drawing.Point(12, 644);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.Btn_Logout.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.Btn_Logout.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Logout.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Logout.Size = new System.Drawing.Size(143, 41);
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
            this.Lbl_Ad_Soyad.Location = new System.Drawing.Point(12, 223);
            this.Lbl_Ad_Soyad.Name = "Lbl_Ad_Soyad";
            this.Lbl_Ad_Soyad.Size = new System.Drawing.Size(299, 45);
            this.Lbl_Ad_Soyad.TabIndex = 6;
            this.Lbl_Ad_Soyad.Text = "Ad_Soyad";
            this.Lbl_Ad_Soyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SoruSayisi
            // 
            this.Lbl_SoruSayisi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_SoruSayisi.Location = new System.Drawing.Point(234, 399);
            this.Lbl_SoruSayisi.Name = "Lbl_SoruSayisi";
            this.Lbl_SoruSayisi.Size = new System.Drawing.Size(100, 30);
            this.Lbl_SoruSayisi.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_SoruSayisi.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SoruSayisi.TabIndex = 5;
            this.Lbl_SoruSayisi.Values.Text = "Soru Sayı";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(19, 399);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(212, 30);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Çözdüğün soru sayısı :";
            // 
            // Lbl_Eposta
            // 
            this.Lbl_Eposta.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_Eposta.Location = new System.Drawing.Point(30, 340);
            this.Lbl_Eposta.Name = "Lbl_Eposta";
            this.Lbl_Eposta.Size = new System.Drawing.Size(72, 30);
            this.Lbl_Eposta.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_Eposta.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Eposta.TabIndex = 3;
            this.Lbl_Eposta.Values.Text = "Eposta";
            // 
            // Lbl_KullaniciAdi
            // 
            this.Lbl_KullaniciAdi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_KullaniciAdi.Location = new System.Drawing.Point(30, 288);
            this.Lbl_KullaniciAdi.Name = "Lbl_KullaniciAdi";
            this.Lbl_KullaniciAdi.Size = new System.Drawing.Size(125, 30);
            this.Lbl_KullaniciAdi.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_KullaniciAdi.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KullaniciAdi.TabIndex = 2;
            this.Lbl_KullaniciAdi.Values.Text = "Kullanıcı_Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 194);
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
            this.Pnl_Questions.Controls.Add(this.chart1);
            this.Pnl_Questions.Location = new System.Drawing.Point(317, 0);
            this.Pnl_Questions.Name = "Pnl_Questions";
            this.Pnl_Questions.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighInternalProfile;
            this.Pnl_Questions.Size = new System.Drawing.Size(710, 637);
            this.Pnl_Questions.StateCommon.Color1 = System.Drawing.Color.White;
            this.Pnl_Questions.StateCommon.Color2 = System.Drawing.Color.Cyan;
            this.Pnl_Questions.TabIndex = 7;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.Btn_added_question);
            this.kryptonPanel2.Controls.Add(this.btn_SinavOl);
            this.kryptonPanel2.Location = new System.Drawing.Point(318, 638);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(709, 59);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Cyan;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 8;
            // 
            // Btn_added_question
            // 
            this.Btn_added_question.AutoSize = true;
            this.Btn_added_question.Location = new System.Drawing.Point(0, 12);
            this.Btn_added_question.Name = "Btn_added_question";
            this.Btn_added_question.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_added_question.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_added_question.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_added_question.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_added_question.Size = new System.Drawing.Size(148, 41);
            this.Btn_added_question.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_added_question.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_added_question.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_added_question.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_added_question.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_added_question.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_added_question.StateCommon.Border.Rounding = 10;
            this.Btn_added_question.StateCommon.Border.Width = 2;
            this.Btn_added_question.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_added_question.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_added_question.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_added_question.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.Btn_added_question.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.Btn_added_question.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.Btn_added_question.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.Btn_added_question.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_added_question.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_added_question.StatePressed.Border.Rounding = 10;
            this.Btn_added_question.StatePressed.Border.Width = 2;
            this.Btn_added_question.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_added_question.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_added_question.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_added_question.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_added_question.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_added_question.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_added_question.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_added_question.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_added_question.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_added_question.StateTracking.Border.Rounding = 10;
            this.Btn_added_question.StateTracking.Border.Width = 2;
            this.Btn_added_question.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_added_question.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_added_question.TabIndex = 3;
            this.Btn_added_question.Values.Text = "ÇİZELGEM";
            // 
            // btn_SinavOl
            // 
            this.btn_SinavOl.Location = new System.Drawing.Point(554, 12);
            this.btn_SinavOl.Name = "btn_SinavOl";
            this.btn_SinavOl.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.btn_SinavOl.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_SinavOl.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_SinavOl.Size = new System.Drawing.Size(143, 41);
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
            // Lbl_TestSayisi
            // 
            this.Lbl_TestSayisi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.Lbl_TestSayisi.Location = new System.Drawing.Point(223, 435);
            this.Lbl_TestSayisi.Name = "Lbl_TestSayisi";
            this.Lbl_TestSayisi.Size = new System.Drawing.Size(114, 30);
            this.Lbl_TestSayisi.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_TestSayisi.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TestSayisi.TabIndex = 8;
            this.Lbl_TestSayisi.Values.Text = "Test_sayısı";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(19, 435);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(198, 30);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "Girdiğin test sayısı :";
            // 
            // StudentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1027, 697);
            this.Controls.Add(this.Pnd_TeacherInfo);
            this.Controls.Add(this.Pnl_Questions);
            this.Controls.Add(this.kryptonPanel2);
            this.Name = "StudentDashboardForm";
            this.Text = "StudentDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnd_TeacherInfo)).EndInit();
            this.Pnd_TeacherInfo.ResumeLayout(false);
            this.Pnd_TeacherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_Questions)).EndInit();
            this.Pnl_Questions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_added_question;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_SinavOl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_TestSayisi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}