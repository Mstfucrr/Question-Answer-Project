using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.user.StudentUserForm;
using Question_Answer.user.UserClass;
using Question_Answer.user.UserClasses;

namespace Question_Answer.user.UserForms
{
    public partial class UserLoginForm : KryptonForm
    {
        public UserLoginForm()
        {
            InitializeComponent();

        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if (ParolaPanel.Visible)
            {
                if (rBtn_ogrenci.Checked)
                {
                    var student = new Student().Login(text_KullaniciAdi.Text, text_Parola.Text);
                    if (student != null)
                    {
                        var form = new StudentDashboardForm(student);
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş");
                    }
                }
                else if (rBtn_ogretmen.Checked)
                {
                    //soru ekleme formu gelecek
                }
                else if (rBtn_Admin.Checked)
                {
                    //sınav sorumlusunun eklemek istediği soruların onaylanması
                }

            }
            else
            {
                if (rBtn_ogrenci.Checked)
                {
                    var student = new Student().GetPassword<Student>("Students",text_KullaniciAdi.Text, text_Eposta.Text);
                    MessageBox.Show(student != null ? $"Şifreniz : {student.Password}" : "Hatalı kullanıcı adı veya eposta");
                }
                else
                {
                    var teacher = new Teacher().GetPassword<Teacher>("Teachers",text_KullaniciAdi.Text, text_Eposta.Text);

                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btn_GirisYap.Text = @"Şifremi göster";
            linkLabel1.Visible = false;
            EpostaPanel.Visible = true;
            ParolaPanel.Visible = false;
        }

    }
}
