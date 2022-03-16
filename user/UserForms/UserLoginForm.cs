using System;
using System.Windows.Forms;
using Question_Answer.user.StudentUserForm;
using Question_Answer.user.UserClass;
using Question_Answer.user.UserClasses;

namespace Question_Answer.user.UserForms
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();

        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            var usr = new Student().Login("mhmt", "mhmt");

            if (usr != null)
            {
                MessageBox.Show("Başarıyla giriş yaptın");
                switch (usr.Role)
                {
                    case "Öğrenci":
                    {
                        StudentDashboardForm form = new StudentDashboardForm(usr);
                        form.Show();
                        this.Close();
                        break;
                    }
                    case "Öğrentmen":
                    {

                    }
                        break;
                    case "Admin":
                    {
                
                    }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Text = "Email Adresiniz :";
            btn_GirisYap.Visible = false;
            btn_SifreGetir.Visible = true;
            textParola.Visible = false;
            textEposta.Visible = true;
            linkLabel1.Visible = false;
            linkLabel2.Visible = true;
        }

        private void btn_SifreGetir_Click(object sender, EventArgs e)
        {
            var user = new User().GetPassword<User>(textKullaniciAdi.Text,textEposta.Text);
            MessageBox.Show(user != null ? $"Şifreniz : {user.Password}" : "Hatalı kullanıcı adı veya eposta");
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Text = "Password :";
            btn_GirisYap.Visible = true;
            btn_SifreGetir.Visible = false;
            textParola.Visible = true;
            textEposta.Visible = false;
            linkLabel1.Visible = true;
            linkLabel2.Visible = false;
        }
    }
}
