using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MongoDB.Bson;
using Question_Answer.Questions;
using Question_Answer.user.UserClass;
using Question_Answer.user.UserClasses;


namespace Question_Answer.user.UserForms

{
    public partial class UserRegisterForm : KryptonForm
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            var db = new Database.MongoDB();

            foreach (var kryptonTextBox in kryptonPanel1.Controls.OfType<KryptonTextBox>())
            {
                if (kryptonTextBox.Text.Length == 0)
                {
                    MessageBox.Show(@"Lütfen tüm boşlukları doldurun");
                    return;
                }

                if (text_Parola.Text.Length < 5)
                {
                    MessageBox.Show(@"Parola uzunluğu en az 5 olmalı");
                    return;
                }
            }

            if (new User().UsersUsernameAndEmailCheck(text_KullaniciAdi.Text))
            {
                var Role = rBtn_ogrenci.Checked
                    ? rBtn_ogrenci.Text
                    : rBtn_ogretmen.Text;
                var answeredQuestionsList = new List<AnsweredQuestions>();
                var addedQuestionsIdList = new List<ObjectId>();
                
                switch (Role)
                {
                    case "Öğrenci":
                    {
                        var student = new Student
                        {
                            Username = text_KullaniciAdi.Text,
                            Password = text_Parola.Text,
                            Name = text_Ad.Text,
                            Lastname = text_Soyad.Text,
                            Email = text_Eposta.Text,
                            Role = "Öğrenci",
                            TrueCount = 0,
                            FalseCount = 0,
                            AnsweredQuestionsList = answeredQuestionsList

                        };
                        db.InsertRecord("Students", student);
                        MessageBox.Show($"Öğrenci başarıyla kayıt oldu hoş geldiniz {student.Name}");
                        break;
                    }
                    case "Öğretmen":
                        var teacher = new Teacher
                        {
                            Username = text_KullaniciAdi.Text,
                            Password = text_Parola.Text,
                            Name = text_Ad.Text,
                            Lastname = text_Soyad.Text,
                            Email = text_Eposta.Text,
                            Role = "Öğretmen",
                            AddedQuestionCount = 0,
                            AddedQuestionsIds = addedQuestionsIdList
                        };
                        db.InsertRecord("Teachers",teacher);
                        MessageBox.Show($"Öğretmen başarıyla kayıt oldu hoş geldiniz {teacher.Name}");

                        break;
                }
            }
            else
            {
                MessageBox.Show(@"Bu kullanıcı adı zaten kullanımda");
                text_KullaniciAdi.StateCommon.Content.Color1 = Color.Red;
                text_Parola.Text = "";
            }

        }

        private void textKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (text_KullaniciAdi.StateCommon.Content.Color1 == Color.Red)
            {
                text_KullaniciAdi.StateCommon.Content.Color1 = Color.Black;
            }
        }

    }
}
