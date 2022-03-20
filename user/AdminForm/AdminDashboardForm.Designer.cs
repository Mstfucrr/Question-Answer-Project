namespace Question_Answer.user.AdminForm
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.Pnd_TeacherInfo = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Btn_Logout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Lbl_Ad_Soyad = new System.Windows.Forms.Label();
            this.Lbl_Eposta = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Lbl_KullaniciAdi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gridViewUsersInfo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Kullanıcı_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test_Sayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Btn_UnconfirmedQuestions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_ConfirmedQuestions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Students = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Teachers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_next = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pnd_TeacherInfo)).BeginInit();
            this.Pnd_TeacherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_1)).BeginInit();
            this.Pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsersInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnd_TeacherInfo
            // 
            this.Pnd_TeacherInfo.Controls.Add(this.Btn_Teachers);
            this.Pnd_TeacherInfo.Controls.Add(this.Btn_Students);
            this.Pnd_TeacherInfo.Controls.Add(this.Btn_Logout);
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_Ad_Soyad);
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_Eposta);
            this.Pnd_TeacherInfo.Controls.Add(this.Lbl_KullaniciAdi);
            this.Pnd_TeacherInfo.Controls.Add(this.pictureBox1);
            this.Pnd_TeacherInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnd_TeacherInfo.Location = new System.Drawing.Point(0, 0);
            this.Pnd_TeacherInfo.MinimumSize = new System.Drawing.Size(317, 615);
            this.Pnd_TeacherInfo.Name = "Pnd_TeacherInfo";
            this.Pnd_TeacherInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Pnd_TeacherInfo.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.Pnd_TeacherInfo.Size = new System.Drawing.Size(317, 695);
            this.Pnd_TeacherInfo.StateCommon.Color1 = System.Drawing.SystemColors.HotTrack;
            this.Pnd_TeacherInfo.StateCommon.Color2 = System.Drawing.Color.Black;
            this.Pnd_TeacherInfo.TabIndex = 3;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Logout.Location = new System.Drawing.Point(12, 642);
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
            // Pnl_1
            // 
            this.Pnl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_1.AutoScroll = true;
            this.Pnl_1.Controls.Add(this.gridViewUsersInfo);
            this.Pnl_1.Location = new System.Drawing.Point(317, 0);
            this.Pnl_1.Name = "Pnl_1";
            this.Pnl_1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate;
            this.Pnl_1.Size = new System.Drawing.Size(739, 635);
            this.Pnl_1.StateCommon.Color1 = System.Drawing.Color.White;
            this.Pnl_1.StateCommon.Color2 = System.Drawing.SystemColors.HotTrack;
            this.Pnl_1.TabIndex = 4;
            // 
            // gridViewUsersInfo
            // 
            this.gridViewUsersInfo.AllowUserToAddRows = false;
            this.gridViewUsersInfo.AllowUserToDeleteRows = false;
            this.gridViewUsersInfo.AllowUserToOrderColumns = true;
            this.gridViewUsersInfo.ColumnHeadersHeight = 29;
            this.gridViewUsersInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kullanıcı_Adi,
            this.Adi,
            this.Soyad,
            this.Eposta,
            this.Test_Sayisi});
            this.gridViewUsersInfo.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.gridViewUsersInfo.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.gridViewUsersInfo.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.gridViewUsersInfo.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.gridViewUsersInfo.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.gridViewUsersInfo.HideOuterBorders = true;
            this.gridViewUsersInfo.Location = new System.Drawing.Point(22, 47);
            this.gridViewUsersInfo.MultiSelect = false;
            this.gridViewUsersInfo.Name = "gridViewUsersInfo";
            this.gridViewUsersInfo.ReadOnly = true;
            this.gridViewUsersInfo.RowHeadersVisible = false;
            this.gridViewUsersInfo.RowHeadersWidth = 51;
            this.gridViewUsersInfo.RowTemplate.Height = 24;
            this.gridViewUsersInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUsersInfo.Size = new System.Drawing.Size(694, 517);
            this.gridViewUsersInfo.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.gridViewUsersInfo.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.gridViewUsersInfo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.gridViewUsersInfo.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.gridViewUsersInfo.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.gridViewUsersInfo.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.gridViewUsersInfo.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gridViewUsersInfo.StateCommon.DataCell.Border.Rounding = 10;
            this.gridViewUsersInfo.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.gridViewUsersInfo.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.gridViewUsersInfo.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Transparent;
            this.gridViewUsersInfo.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Transparent;
            this.gridViewUsersInfo.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gridViewUsersInfo.StateCommon.HeaderColumn.Border.Rounding = 10;
            this.gridViewUsersInfo.StateCommon.HeaderColumn.Border.Width = 1;
            this.gridViewUsersInfo.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.gridViewUsersInfo.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewUsersInfo.TabIndex = 14;
            // 
            // Kullanıcı_Adi
            // 
            this.Kullanıcı_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kullanıcı_Adi.FillWeight = 118.3155F;
            this.Kullanıcı_Adi.HeaderText = "Kullanıcı Adı";
            this.Kullanıcı_Adi.MinimumWidth = 6;
            this.Kullanıcı_Adi.Name = "Kullanıcı_Adi";
            this.Kullanıcı_Adi.ReadOnly = true;
            this.Kullanıcı_Adi.Width = 128;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adi.FillWeight = 118.3155F;
            this.Adi.HeaderText = "Ad";
            this.Adi.MinimumWidth = 6;
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            this.Adi.Width = 61;
            // 
            // Soyad
            // 
            this.Soyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Soyad.FillWeight = 118.3155F;
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.Width = 83;
            // 
            // Eposta
            // 
            this.Eposta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eposta.FillWeight = 118.3155F;
            this.Eposta.HeaderText = "Eposta";
            this.Eposta.MinimumWidth = 6;
            this.Eposta.Name = "Eposta";
            this.Eposta.ReadOnly = true;
            this.Eposta.Width = 87;
            // 
            // Test_Sayisi
            // 
            this.Test_Sayisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Test_Sayisi.FillWeight = 20F;
            this.Test_Sayisi.HeaderText = "Test Sayısı";
            this.Test_Sayisi.MinimumWidth = 6;
            this.Test_Sayisi.Name = "Test_Sayisi";
            this.Test_Sayisi.ReadOnly = true;
            this.Test_Sayisi.Width = 111;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.Btn_back);
            this.kryptonPanel2.Controls.Add(this.Btn_UnconfirmedQuestions);
            this.kryptonPanel2.Controls.Add(this.Btn_next);
            this.kryptonPanel2.Controls.Add(this.Btn_ConfirmedQuestions);
            this.kryptonPanel2.Location = new System.Drawing.Point(317, 632);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(739, 63);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.SystemColors.HotTrack;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 5;
            // 
            // Btn_UnconfirmedQuestions
            // 
            this.Btn_UnconfirmedQuestions.Location = new System.Drawing.Point(455, 12);
            this.Btn_UnconfirmedQuestions.MinimumSize = new System.Drawing.Size(208, 41);
            this.Btn_UnconfirmedQuestions.Name = "Btn_UnconfirmedQuestions";
            this.Btn_UnconfirmedQuestions.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_UnconfirmedQuestions.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_UnconfirmedQuestions.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.Size = new System.Drawing.Size(244, 41);
            this.Btn_UnconfirmedQuestions.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_UnconfirmedQuestions.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_UnconfirmedQuestions.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_UnconfirmedQuestions.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_UnconfirmedQuestions.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_UnconfirmedQuestions.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_UnconfirmedQuestions.StateCommon.Border.Rounding = 10;
            this.Btn_UnconfirmedQuestions.StateCommon.Border.Width = 2;
            this.Btn_UnconfirmedQuestions.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_UnconfirmedQuestions.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.Btn_UnconfirmedQuestions.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.Btn_UnconfirmedQuestions.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.Btn_UnconfirmedQuestions.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.Btn_UnconfirmedQuestions.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_UnconfirmedQuestions.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_UnconfirmedQuestions.StatePressed.Border.Rounding = 10;
            this.Btn_UnconfirmedQuestions.StatePressed.Border.Width = 2;
            this.Btn_UnconfirmedQuestions.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_UnconfirmedQuestions.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_UnconfirmedQuestions.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_UnconfirmedQuestions.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_UnconfirmedQuestions.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_UnconfirmedQuestions.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_UnconfirmedQuestions.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_UnconfirmedQuestions.StateTracking.Border.Rounding = 10;
            this.Btn_UnconfirmedQuestions.StateTracking.Border.Width = 2;
            this.Btn_UnconfirmedQuestions.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_UnconfirmedQuestions.TabIndex = 6;
            this.Btn_UnconfirmedQuestions.Values.Text = "ONAYSIZ SORULAR";
            this.Btn_UnconfirmedQuestions.Click += new System.EventHandler(this.Btn_UnconfirmedQuestions_Click);
            // 
            // Btn_ConfirmedQuestions
            // 
            this.Btn_ConfirmedQuestions.Location = new System.Drawing.Point(22, 12);
            this.Btn_ConfirmedQuestions.MinimumSize = new System.Drawing.Size(195, 41);
            this.Btn_ConfirmedQuestions.Name = "Btn_ConfirmedQuestions";
            this.Btn_ConfirmedQuestions.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_ConfirmedQuestions.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_ConfirmedQuestions.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.Size = new System.Drawing.Size(251, 41);
            this.Btn_ConfirmedQuestions.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_ConfirmedQuestions.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_ConfirmedQuestions.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_ConfirmedQuestions.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_ConfirmedQuestions.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_ConfirmedQuestions.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_ConfirmedQuestions.StateCommon.Border.Rounding = 10;
            this.Btn_ConfirmedQuestions.StateCommon.Border.Width = 2;
            this.Btn_ConfirmedQuestions.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ConfirmedQuestions.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.Btn_ConfirmedQuestions.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.Btn_ConfirmedQuestions.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.Btn_ConfirmedQuestions.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.Btn_ConfirmedQuestions.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_ConfirmedQuestions.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_ConfirmedQuestions.StatePressed.Border.Rounding = 10;
            this.Btn_ConfirmedQuestions.StatePressed.Border.Width = 2;
            this.Btn_ConfirmedQuestions.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ConfirmedQuestions.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_ConfirmedQuestions.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_ConfirmedQuestions.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_ConfirmedQuestions.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_ConfirmedQuestions.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_ConfirmedQuestions.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_ConfirmedQuestions.StateTracking.Border.Rounding = 10;
            this.Btn_ConfirmedQuestions.StateTracking.Border.Width = 2;
            this.Btn_ConfirmedQuestions.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_ConfirmedQuestions.TabIndex = 5;
            this.Btn_ConfirmedQuestions.Values.Text = "ONAYLI SORULAR";
            this.Btn_ConfirmedQuestions.Click += new System.EventHandler(this.Btn_ConfirmedQuestions_Click);
            // 
            // Btn_Students
            // 
            this.Btn_Students.AutoSize = true;
            this.Btn_Students.Location = new System.Drawing.Point(30, 391);
            this.Btn_Students.Name = "Btn_Students";
            this.Btn_Students.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Students.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Students.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Students.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Students.Size = new System.Drawing.Size(159, 41);
            this.Btn_Students.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Students.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Students.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Students.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Students.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Students.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Students.StateCommon.Border.Rounding = 10;
            this.Btn_Students.StateCommon.Border.Width = 2;
            this.Btn_Students.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Students.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Students.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Students.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.Btn_Students.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.Btn_Students.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.Btn_Students.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.Btn_Students.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Students.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Students.StatePressed.Border.Rounding = 10;
            this.Btn_Students.StatePressed.Border.Width = 2;
            this.Btn_Students.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Students.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Students.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Students.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_Students.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_Students.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_Students.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_Students.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Students.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Students.StateTracking.Border.Rounding = 10;
            this.Btn_Students.StateTracking.Border.Width = 2;
            this.Btn_Students.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Students.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Students.TabIndex = 3;
            this.Btn_Students.Values.Text = "ÖĞRENCİLER";
            this.Btn_Students.Click += new System.EventHandler(this.Btn_Students_Click);
            // 
            // Btn_Teachers
            // 
            this.Btn_Teachers.Location = new System.Drawing.Point(30, 454);
            this.Btn_Teachers.Name = "Btn_Teachers";
            this.Btn_Teachers.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Teachers.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Teachers.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Teachers.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Teachers.Size = new System.Drawing.Size(173, 41);
            this.Btn_Teachers.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Teachers.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Teachers.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Teachers.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_Teachers.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Teachers.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Teachers.StateCommon.Border.Rounding = 10;
            this.Btn_Teachers.StateCommon.Border.Width = 2;
            this.Btn_Teachers.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Teachers.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Teachers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Teachers.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.Btn_Teachers.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.Btn_Teachers.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.Btn_Teachers.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.Btn_Teachers.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Teachers.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Teachers.StatePressed.Border.Rounding = 10;
            this.Btn_Teachers.StatePressed.Border.Width = 2;
            this.Btn_Teachers.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Teachers.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Teachers.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Teachers.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_Teachers.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_Teachers.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_Teachers.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_Teachers.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Teachers.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_Teachers.StateTracking.Border.Rounding = 10;
            this.Btn_Teachers.StateTracking.Border.Width = 2;
            this.Btn_Teachers.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_Teachers.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_Teachers.TabIndex = 0;
            this.Btn_Teachers.Values.Text = "ÖĞRETMENLER";
            this.Btn_Teachers.Click += new System.EventHandler(this.Btn_Teachers_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(326, 12);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_back.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_back.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_back.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_back.Size = new System.Drawing.Size(36, 41);
            this.Btn_back.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_back.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_back.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_back.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_back.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_back.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_back.StateCommon.Border.Rounding = 10;
            this.Btn_back.StateCommon.Border.Width = 2;
            this.Btn_back.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_back.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_back.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_back.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.Btn_back.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.Btn_back.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.Btn_back.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.Btn_back.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_back.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_back.StatePressed.Border.Rounding = 10;
            this.Btn_back.StatePressed.Border.Width = 2;
            this.Btn_back.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_back.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_back.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_back.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_back.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_back.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_back.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_back.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_back.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_back.StateTracking.Border.Rounding = 10;
            this.Btn_back.StateTracking.Border.Width = 2;
            this.Btn_back.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_back.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_back.TabIndex = 16;
            this.Btn_back.Values.Text = "<";
            this.Btn_back.Visible = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Btn_next
            // 
            this.Btn_next.Location = new System.Drawing.Point(368, 12);
            this.Btn_next.Name = "Btn_next";
            this.Btn_next.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_next.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_next.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_next.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_next.Size = new System.Drawing.Size(36, 41);
            this.Btn_next.StateCommon.Back.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_next.StateCommon.Back.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_next.StateCommon.Border.Color1 = System.Drawing.Color.MediumVioletRed;
            this.Btn_next.StateCommon.Border.Color2 = System.Drawing.Color.MediumVioletRed;
            this.Btn_next.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_next.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_next.StateCommon.Border.Rounding = 10;
            this.Btn_next.StateCommon.Border.Width = 2;
            this.Btn_next.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_next.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_next.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_next.StatePressed.Back.Color1 = System.Drawing.Color.HotPink;
            this.Btn_next.StatePressed.Back.Color2 = System.Drawing.Color.HotPink;
            this.Btn_next.StatePressed.Border.Color1 = System.Drawing.Color.HotPink;
            this.Btn_next.StatePressed.Border.Color2 = System.Drawing.Color.HotPink;
            this.Btn_next.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_next.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_next.StatePressed.Border.Rounding = 10;
            this.Btn_next.StatePressed.Border.Width = 2;
            this.Btn_next.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_next.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_next.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_next.StateTracking.Back.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_next.StateTracking.Back.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_next.StateTracking.Border.Color1 = System.Drawing.Color.DeepPink;
            this.Btn_next.StateTracking.Border.Color2 = System.Drawing.Color.DeepPink;
            this.Btn_next.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_next.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_next.StateTracking.Border.Rounding = 10;
            this.Btn_next.StateTracking.Border.Width = 2;
            this.Btn_next.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_next.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_next.TabIndex = 15;
            this.Btn_next.Values.Text = ">";
            this.Btn_next.Visible = false;
            this.Btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 695);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.Pnd_TeacherInfo);
            this.Controls.Add(this.Pnl_1);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.Pnd_TeacherInfo)).EndInit();
            this.Pnd_TeacherInfo.ResumeLayout(false);
            this.Pnd_TeacherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_1)).EndInit();
            this.Pnl_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsersInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel Pnd_TeacherInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Logout;
        private System.Windows.Forms.Label Lbl_Ad_Soyad;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_Eposta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_KullaniciAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel Pnl_1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_ConfirmedQuestions;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Students;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Teachers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_UnconfirmedQuestions;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridViewUsersInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullanıcı_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Sayisi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_back;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_next;
    }
}