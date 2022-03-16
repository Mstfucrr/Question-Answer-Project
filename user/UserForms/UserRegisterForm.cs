using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using Question_Answer.user.UserClass;
using Question_Answer.user.UserClasses;

namespace Question_Answer.user.UserForms
{
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
            rBtn_Ogrenci.Checked = true;
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            var db = new Database.MongoDB();

            if (db.LoadRecords<User>("Students").All(kullanici => kullanici.Username != textKullaniciAdi.Text))
            {
                var Role = rBtn_Ogrenci.Checked
                    ? rBtn_Ogrenci.Text
                    : (rBtn_Ogretmen.Checked ? rBtn_Ogretmen.Text : rBtn_Admin.Text);
                var AnsweredQuestionsList = new List<AnsweredQuestions>();

                AnsweredQuestionsList.Add(new AnsweredQuestions
                {
                    TrueOrFalse = true,
                    AnsweredQuestionIds = new ObjectId("622d5148632fadd4f8efb3bd")
                });
                if (Role == "Öğrenci")
                {
                    Student student = new Student
                    {
                        Username = textKullaniciAdi.Text,
                        Password = textParola.Text,
                        Name = textAd.Text,
                        Lastname = textSoyad.Text,
                        Email = textMail.Text,
                        Role = "Öğrenci",
                        TrueCount = 1,
                        FalseCount = 0,
                        AnsweredQuestionsList = AnsweredQuestionsList

                    };
                    db.InsertRecord("Students", student);
                    MessageBox.Show($"Öğrenci Başarıyla kayıt oldu hoş geldiniz {student.Name}");

                }


                //var user = new User
                //{
                //    Username = textKullaniciAdi.Text,
                //    Password = textParola.Text,
                //    Name = textAd.Text,
                //    Lastname = textSoyad.Text,
                //    Email = textMail.Text,
                //    Role = rBtn_Ogrenci.Checked ? rBtn_Ogrenci.Text : (rBtn_Ogretmen.Checked ? rBtn_Ogretmen.Text : rBtn_Admin.Text)
                //};

                //db.InsertRecord("User", user);
                //MessageBox.Show($"Kullanıcı Başarıyla kayıt oldu hoş geldiniz {user.Name}");
            }
            else
            {
                MessageBox.Show(@"Bu kullanıcı adı zaten kullanımda");
                textKullaniciAdi.ForeColor = Color.Red;
                textParola.Text = "";
            }

        }

        private void textKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textKullaniciAdi.ForeColor == Color.Red) 
                textKullaniciAdi.ForeColor = Color.Black;
        }
    }
}
