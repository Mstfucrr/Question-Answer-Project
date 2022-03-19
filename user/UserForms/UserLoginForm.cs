using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.user.StudentUserForm;
using Question_Answer.user.TeacherForm;
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
                    var student = new User().Login<Student>("Students",text_KullaniciAdi.Text, text_Parola.Text);
                    if (student != null)
                    {
                        var studentDashboard = new StudentDashboardForm(student);
                        studentDashboard.Closed += (o, args) => this.Close();
                        studentDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş");
                    }
                }
                else if (rBtn_ogretmen.Checked)
                {
                    //var teacher = new User().Login<Teacher>("Teachers",text_KullaniciAdi.Text, text_Parola.Text);
                    var teacher = new User().Login<Teacher>("Teachers","hlmi", "hlmi");
                    if (teacher != null)
                    {
                        // soru ekleme formu gelecek
                        var teacherDashboard = new TeacherDashboardForm(teacher);
                        teacherDashboard.Closed += (o, args) => this.Close();
                        teacherDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş");
                    }
                    //soru ekleme formu gelecek
                }
                else if (rBtn_Admin.Checked)
                {
                    //Öğretmenin eklemek istediği soruların onaylanması

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
                    MessageBox.Show(teacher != null ? $"Şifreniz : {teacher.Password}" : "Hatalı kullanıcı adı veya eposta");

                }

            }
        }


        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            btn_GirisYap.Text = @"Şifremi göster";
            kryptonLinkLabel1.Visible = false;
            EpostaPanel.Visible = true;
            ParolaPanel.Visible = false;
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            var registerfrom = new UserRegisterForm();
            registerfrom.Show();
            registerfrom.Closed += (o, args) => this.Close();
            this.Hide();
        }
    }
}
