using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.Questions;
using Question_Answer.Questions.QuestionForms;
using Question_Answer.user.UserClasses;
using Question_Answer.user.UserForms;

namespace Question_Answer.user.TeacherForm
{
    public partial class TeacherDashboardForm : KryptonForm
    {
        private readonly Teacher _teacher;
        private List<Question> _ownQuestionList;
        private int _questionNum;
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
            Btn_back.Visible = false;
            Btn_next.Visible = false;
            Pnl_Questions.Controls.Clear();
            var questionAddForm = new QuestionAddForm(_teacher);
            questionAddForm.FormBorderStyle = FormBorderStyle.None;
            questionAddForm.TopLevel = false;
            questionAddForm.AutoScroll = false;
            Pnl_Questions.Width = questionAddForm.Width + 20;
            this.Height = questionAddForm.Height + 85;
            Pnl_Questions.Controls.Add(questionAddForm);
            questionAddForm.Show();
            Lbl_SoruSayisi.Text = _teacher.AddedQuestionCount.ToString();
            

        }

        private void Btn_added_question_Click(object sender, EventArgs e)
        {

            Pnl_Questions.Controls.Clear();
            _ownQuestionList = _teacher.GetAddedQuestions();
            if (_ownQuestionList.Count == 0)
            {
                MessageBox.Show(@"Lütfen soru ekleyiniz");
                return;
            }
            GetQuestion(0);
            Btn_next.Visible = true;
            Btn_back.Visible = true;
            Lbl_SoruSayisi.Text = _teacher.AddedQuestionCount.ToString();

        }

        private void GetQuestion(int index)
        {
            Pnl_Questions.Controls.Clear();
            var ownQuestion = _ownQuestionList[index];
            var teacherOwnQuestionForm = new TeacherOwnQuestionForm(ownQuestion);
            teacherOwnQuestionForm.TopLevel = false;
            teacherOwnQuestionForm.AutoSize = false;
            this.Width = Pnd_TeacherInfo.Width + teacherOwnQuestionForm.Width + 20;
            Pnl_Questions.Width = teacherOwnQuestionForm.Width + 20;
            this.Height = teacherOwnQuestionForm.Height + 100;
            Pnl_Questions.Controls.Add(teacherOwnQuestionForm);
            teacherOwnQuestionForm.Show();


        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            if (_questionNum < _ownQuestionList.Count - 1)
                _questionNum++;
            GetQuestion(_questionNum);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (_questionNum > 0)
                _questionNum--;

            GetQuestion(_questionNum);

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
