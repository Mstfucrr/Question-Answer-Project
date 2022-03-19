using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.Questions.QuestionForms;
using Question_Answer.user.UserClasses;
using Question_Answer.user.UserForms;

namespace Question_Answer.user.TeacherForm
{
    public partial class TeacherDashboardForm : KryptonForm
    {
        private readonly Teacher _teacher;
        public TeacherDashboardForm(Teacher teacher)
        {
            InitializeComponent();
            this._teacher = teacher;
        }

        private void TeacherDashboardForm_Load(object sender, EventArgs e)
        {
            Lbl_Ad_Soyad.Text = _teacher.Name + " " + _teacher.Lastname;
            Lbl_Eposta.Text = _teacher.Email;
            Lbl_KullaniciAdi.Text = _teacher.Username;
            Lbl_SoruSayisi.Text = _teacher.AddedQuestionCount.ToString();
        }

        private void Btn_Add_Question_Click(object sender, EventArgs e)
        {
            Pnl_Questions.Controls.Clear();
            var questionAddForm = new QuestionAddForm(_teacher);
            questionAddForm.FormBorderStyle = FormBorderStyle.None;
            questionAddForm.TopLevel = false;
            questionAddForm.AutoScroll = false;
            Pnl_Questions.Width = questionAddForm.Width+20;
            this.Height = questionAddForm.Height;
            Pnl_Questions.Controls.Add(questionAddForm);
            questionAddForm.Show();

        }

        private void Btn_added_question_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Closed += (o, args) => this.Close();
            userLoginForm.Show();
            this.Hide();
        }
    }
}
