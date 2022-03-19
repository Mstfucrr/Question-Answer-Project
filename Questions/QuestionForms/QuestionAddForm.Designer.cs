namespace Question_Answer.Questions.QuestionForms
{
    partial class QuestionAddForm
    {

        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResim = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_kaydet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.textCevap5 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textCevap4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textCevap3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textCevap2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textCevap1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textSoru = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.textUnite = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textKonu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Soru :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(0, 3);
            this.btnResim.Name = "btnResim";
            this.btnResim.OverrideDefault.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnResim.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.btnResim.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnResim.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnResim.Size = new System.Drawing.Size(158, 46);
            this.btnResim.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnResim.StateCommon.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.btnResim.StateCommon.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnResim.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btnResim.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnResim.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnResim.StateCommon.Border.Rounding = 10;
            this.btnResim.StateCommon.Border.Width = 2;
            this.btnResim.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnResim.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnResim.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.StatePressed.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnResim.StatePressed.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnResim.StatePressed.Border.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnResim.StatePressed.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnResim.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnResim.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnResim.StatePressed.Border.Rounding = 10;
            this.btnResim.StatePressed.Border.Width = 2;
            this.btnResim.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnResim.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnResim.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnResim.StateTracking.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnResim.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnResim.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnResim.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnResim.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnResim.StateTracking.Border.Rounding = 10;
            this.btnResim.StateTracking.Border.Width = 2;
            this.btnResim.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnResim.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnResim.TabIndex = 31;
            this.btnResim.Values.Text = "RESİM EKLE";
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kaydet.Location = new System.Drawing.Point(540, 549);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.OverrideDefault.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.btn_kaydet.OverrideDefault.Back.Color2 = System.Drawing.Color.LimeGreen;
            this.btn_kaydet.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_kaydet.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_kaydet.Size = new System.Drawing.Size(139, 46);
            this.btn_kaydet.StateCommon.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.btn_kaydet.StateCommon.Back.Color2 = System.Drawing.Color.LimeGreen;
            this.btn_kaydet.StateCommon.Border.Color1 = System.Drawing.Color.ForestGreen;
            this.btn_kaydet.StateCommon.Border.Color2 = System.Drawing.Color.ForestGreen;
            this.btn_kaydet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_kaydet.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_kaydet.StateCommon.Border.Rounding = 10;
            this.btn_kaydet.StateCommon.Border.Width = 2;
            this.btn_kaydet.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_kaydet.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_kaydet.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.StatePressed.Back.Color1 = System.Drawing.Color.PaleGreen;
            this.btn_kaydet.StatePressed.Back.Color2 = System.Drawing.Color.PaleGreen;
            this.btn_kaydet.StatePressed.Border.Color1 = System.Drawing.Color.PaleGreen;
            this.btn_kaydet.StatePressed.Border.Color2 = System.Drawing.Color.PaleGreen;
            this.btn_kaydet.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_kaydet.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_kaydet.StatePressed.Border.Rounding = 10;
            this.btn_kaydet.StatePressed.Border.Width = 2;
            this.btn_kaydet.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_kaydet.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_kaydet.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.StateTracking.Back.Color1 = System.Drawing.Color.LightGreen;
            this.btn_kaydet.StateTracking.Back.Color2 = System.Drawing.Color.LightGreen;
            this.btn_kaydet.StateTracking.Border.Color1 = System.Drawing.Color.LightGreen;
            this.btn_kaydet.StateTracking.Border.Color2 = System.Drawing.Color.LightGreen;
            this.btn_kaydet.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_kaydet.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_kaydet.StateTracking.Border.Rounding = 10;
            this.btn_kaydet.StateTracking.Border.Width = 2;
            this.btn_kaydet.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_kaydet.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_kaydet.TabIndex = 30;
            this.btn_kaydet.Values.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(256, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ünite :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(256, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Konu :";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Depth = 0;
            this.radioButton5.Location = new System.Drawing.Point(6, 484);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Ripple = true;
            this.radioButton5.Size = new System.Drawing.Size(35, 37);
            this.radioButton5.TabIndex = 26;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Depth = 0;
            this.radioButton4.Location = new System.Drawing.Point(6, 417);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Ripple = true;
            this.radioButton4.Size = new System.Drawing.Size(35, 37);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Depth = 0;
            this.radioButton3.Location = new System.Drawing.Point(6, 353);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Ripple = true;
            this.radioButton3.Size = new System.Drawing.Size(35, 37);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Depth = 0;
            this.radioButton2.Location = new System.Drawing.Point(6, 295);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Ripple = true;
            this.radioButton2.Size = new System.Drawing.Size(35, 37);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Depth = 0;
            this.radioButton1.Location = new System.Drawing.Point(6, 234);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Ripple = true;
            this.radioButton1.Size = new System.Drawing.Size(35, 37);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // textCevap5
            // 
            this.textCevap5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCevap5.Location = new System.Drawing.Point(58, 484);
            this.textCevap5.Name = "textCevap5";
            this.textCevap5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.textCevap5.Size = new System.Drawing.Size(618, 33);
            this.textCevap5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textCevap5.StateCommon.Border.Rounding = 10;
            this.textCevap5.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCevap5.TabIndex = 21;
            // 
            // textCevap4
            // 
            this.textCevap4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCevap4.Location = new System.Drawing.Point(58, 421);
            this.textCevap4.Name = "textCevap4";
            this.textCevap4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.textCevap4.Size = new System.Drawing.Size(618, 33);
            this.textCevap4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textCevap4.StateCommon.Border.Rounding = 10;
            this.textCevap4.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCevap4.TabIndex = 20;
            // 
            // textCevap3
            // 
            this.textCevap3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCevap3.Location = new System.Drawing.Point(58, 357);
            this.textCevap3.Name = "textCevap3";
            this.textCevap3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.textCevap3.Size = new System.Drawing.Size(618, 33);
            this.textCevap3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textCevap3.StateCommon.Border.Rounding = 10;
            this.textCevap3.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCevap3.TabIndex = 19;
            // 
            // textCevap2
            // 
            this.textCevap2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCevap2.Location = new System.Drawing.Point(58, 299);
            this.textCevap2.Name = "textCevap2";
            this.textCevap2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.textCevap2.Size = new System.Drawing.Size(618, 33);
            this.textCevap2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textCevap2.StateCommon.Border.Rounding = 10;
            this.textCevap2.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCevap2.TabIndex = 18;
            // 
            // textCevap1
            // 
            this.textCevap1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCevap1.Location = new System.Drawing.Point(58, 238);
            this.textCevap1.Name = "textCevap1";
            this.textCevap1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.textCevap1.Size = new System.Drawing.Size(618, 33);
            this.textCevap1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textCevap1.StateCommon.Border.Rounding = 10;
            this.textCevap1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCevap1.TabIndex = 17;
            // 
            // textSoru
            // 
            this.textSoru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSoru.Location = new System.Drawing.Point(83, 95);
            this.textSoru.Name = "textSoru";
            this.textSoru.Size = new System.Drawing.Size(593, 115);
            this.textSoru.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textSoru.StateCommon.Border.Rounding = 10;
            this.textSoru.StateCommon.Border.Width = 1;
            this.textSoru.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textSoru.TabIndex = 16;
            this.textSoru.Text = "";
            // 
            // textUnite
            // 
            this.textUnite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUnite.Location = new System.Drawing.Point(351, 48);
            this.textUnite.Name = "textUnite";
            this.textUnite.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.textUnite.Size = new System.Drawing.Size(325, 33);
            this.textUnite.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textUnite.StateCommon.Border.Rounding = 10;
            this.textUnite.TabIndex = 15;
            // 
            // textKonu
            // 
            this.textKonu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textKonu.Location = new System.Drawing.Point(351, 9);
            this.textKonu.Name = "textKonu";
            this.textKonu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.textKonu.Size = new System.Drawing.Size(325, 33);
            this.textKonu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textKonu.StateCommon.Border.Rounding = 10;
            this.textKonu.TabIndex = 14;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoSize = true;
            this.kryptonPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonPanel1.Size = new System.Drawing.Size(685, 889);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.RoyalBlue;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.IndianRed;
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.TabIndex = 16;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel2.Controls.Add(this.radioButton1);
            this.kryptonPanel2.Controls.Add(this.btnResim);
            this.kryptonPanel2.Controls.Add(this.btn_kaydet);
            this.kryptonPanel2.Controls.Add(this.label1);
            this.kryptonPanel2.Controls.Add(this.label3);
            this.kryptonPanel2.Controls.Add(this.textKonu);
            this.kryptonPanel2.Controls.Add(this.label2);
            this.kryptonPanel2.Controls.Add(this.textUnite);
            this.kryptonPanel2.Controls.Add(this.radioButton5);
            this.kryptonPanel2.Controls.Add(this.textSoru);
            this.kryptonPanel2.Controls.Add(this.radioButton4);
            this.kryptonPanel2.Controls.Add(this.textCevap1);
            this.kryptonPanel2.Controls.Add(this.radioButton3);
            this.kryptonPanel2.Controls.Add(this.textCevap2);
            this.kryptonPanel2.Controls.Add(this.radioButton2);
            this.kryptonPanel2.Controls.Add(this.textCevap3);
            this.kryptonPanel2.Controls.Add(this.textCevap4);
            this.kryptonPanel2.Controls.Add(this.textCevap5);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 291);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(679, 595);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 16;
            // 
            // QuestionAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(685, 889);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(703, 936);
            this.Name = "QuestionAddForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuestionAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textUnite;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRadioButton radioButton5;
        private MaterialSkin.Controls.MaterialRadioButton radioButton4;
        private MaterialSkin.Controls.MaterialRadioButton radioButton3;
        private MaterialSkin.Controls.MaterialRadioButton radioButton2;
        private MaterialSkin.Controls.MaterialRadioButton radioButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textCevap5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textCevap4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textCevap3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textCevap2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textCevap1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox textSoru;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_kaydet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnResim;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}