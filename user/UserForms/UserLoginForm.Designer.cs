namespace Question_Answer.user.UserForms
{
    partial class UserLoginForm
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
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_SifreGetir = new System.Windows.Forms.Button();
            this.textEposta = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GirisYap.Location = new System.Drawing.Point(272, 188);
            this.btn_GirisYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(98, 31);
            this.btn_GirisYap.TabIndex = 0;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // textKullaniciAdi
            // 
            this.textKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKullaniciAdi.Location = new System.Drawing.Point(264, 80);
            this.textKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textKullaniciAdi.Name = "textKullaniciAdi";
            this.textKullaniciAdi.Size = new System.Drawing.Size(205, 29);
            this.textKullaniciAdi.TabIndex = 2;
            // 
            // textParola
            // 
            this.textParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textParola.Location = new System.Drawing.Point(264, 127);
            this.textParola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textParola.Name = "textParola";
            this.textParola.Size = new System.Drawing.Size(205, 29);
            this.textParola.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(119, 198);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_SifreGetir
            // 
            this.btn_SifreGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SifreGetir.Location = new System.Drawing.Point(272, 188);
            this.btn_SifreGetir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SifreGetir.Name = "btn_SifreGetir";
            this.btn_SifreGetir.Size = new System.Drawing.Size(140, 31);
            this.btn_SifreGetir.TabIndex = 6;
            this.btn_SifreGetir.Text = "Şifremi Getir";
            this.btn_SifreGetir.UseVisualStyleBackColor = true;
            this.btn_SifreGetir.Visible = false;
            this.btn_SifreGetir.Click += new System.EventHandler(this.btn_SifreGetir_Click);
            // 
            // textEposta
            // 
            this.textEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEposta.Location = new System.Drawing.Point(264, 128);
            this.textEposta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEposta.Name = "textEposta";
            this.textEposta.Size = new System.Drawing.Size(205, 29);
            this.textEposta.TabIndex = 7;
            this.textEposta.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(119, 198);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 15);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Giriş Yap";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.textEposta);
            this.Controls.Add(this.btn_SifreGetir);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GirisYap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKullaniciAdi;
        private System.Windows.Forms.TextBox textParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_SifreGetir;
        private System.Windows.Forms.TextBox textEposta;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}