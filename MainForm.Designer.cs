namespace Question_Answer
{
    partial class MainForm
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
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.btn_SoruEkle = new System.Windows.Forms.Button();
            this.btn_SoruGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitOl.Location = new System.Drawing.Point(452, 205);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(128, 45);
            this.btn_KayitOl.TabIndex = 0;
            this.btn_KayitOl.Text = "Kayıt ol";
            this.btn_KayitOl.UseVisualStyleBackColor = true;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GirisYap.Location = new System.Drawing.Point(452, 277);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(128, 45);
            this.btn_GirisYap.TabIndex = 1;
            this.btn_GirisYap.Text = "Giriş yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // btn_SoruEkle
            // 
            this.btn_SoruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SoruEkle.Location = new System.Drawing.Point(169, 205);
            this.btn_SoruEkle.Name = "btn_SoruEkle";
            this.btn_SoruEkle.Size = new System.Drawing.Size(150, 45);
            this.btn_SoruEkle.TabIndex = 2;
            this.btn_SoruEkle.Text = "Soru Ekle";
            this.btn_SoruEkle.UseVisualStyleBackColor = true;
            this.btn_SoruEkle.Click += new System.EventHandler(this.btn_SoruEkle_Click);
            // 
            // btn_SoruGetir
            // 
            this.btn_SoruGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SoruGetir.Location = new System.Drawing.Point(169, 277);
            this.btn_SoruGetir.Name = "btn_SoruGetir";
            this.btn_SoruGetir.Size = new System.Drawing.Size(150, 45);
            this.btn_SoruGetir.TabIndex = 3;
            this.btn_SoruGetir.Text = "Soru Getir";
            this.btn_SoruGetir.UseVisualStyleBackColor = true;
            this.btn_SoruGetir.Click += new System.EventHandler(this.btn_SoruGetir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 531);
            this.Controls.Add(this.btn_SoruGetir);
            this.Controls.Add(this.btn_SoruEkle);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.btn_KayitOl);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KayitOl;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.Button btn_SoruEkle;
        private System.Windows.Forms.Button btn_SoruGetir;
    }
}

