using System;
using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.Questions;
using Question_Answer.user.UserClasses;
using Question_Answer.user.UserForms;

namespace Question_Answer.user.AdminForm
{
    public partial class AdminDashboardForm : KryptonForm
    {
        private AdminDashboard adminDashboard;
        private List<Question> _questionList;
        private int _questionNum;
        public AdminDashboardForm()
        {
            InitializeComponent();
            adminDashboard = new AdminDashboard();
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
            if (adminQuestionsForm != null) adminQuestionsForm.Hide();
            Pnl_1.Controls.Clear();
            Pnl_1.Controls.Add(gridViewUsersInfo);
            Btn_back.Visible = false;
            Btn_next.Visible = false;
            gridViewUsersInfo.Visible = true;
            gridViewUsersInfo.Columns[gridViewUsersInfo.Columns.Count - 1].HeaderText = "Çözdüğü test sayısı";
            gridViewUsersInfo.Rows.Clear();
            var AllStudents = adminDashboard.GetAllStudents();
            foreach (var Student in AllStudents)
            {
                gridViewUsersInfo.Rows.Add(new string[]{Student.Username,Student.Name,Student.Lastname,Student.Email,Student.NumberOfQuiz.ToString()});
            }
        }

        private void Btn_Teachers_Click(object sender, EventArgs e)
        {
            if (adminQuestionsForm != null) adminQuestionsForm.Hide();
            Pnl_1.Controls.Clear();
            Pnl_1.Controls.Add(gridViewUsersInfo);

            Btn_back.Visible = false;
            Btn_next.Visible = false;
            gridViewUsersInfo.Visible = true;
            gridViewUsersInfo.Columns[gridViewUsersInfo.Columns.Count - 1].HeaderText = "Sorduğu soru sayısı";
            gridViewUsersInfo.Rows.Clear();
            var AllTeachers = adminDashboard.GetAllTeachers();

            foreach (var teacher in AllTeachers)
            {
                gridViewUsersInfo.Rows.Add(new string[] { teacher.Username, teacher.Name, teacher.Lastname, teacher.Email, teacher.AddedQuestionCount.ToString() });
            }
        }

        private void Btn_ConfirmedQuestions_Click(object sender, EventArgs e)
        {
            Btn_back.Visible = true;
            Btn_next.Visible = true;
            gridViewUsersInfo.Visible = false;
            _questionList = adminDashboard.GetAllConfirmendQuestions();
            _questionNum = 0;
            GetQuestion(_questionNum);
        }
        private void Btn_UnconfirmedQuestions_Click(object sender, EventArgs e)
        {
            Btn_back.Visible = true;
            Btn_next.Visible = true;
            gridViewUsersInfo.Visible = false;
            _questionList = adminDashboard.GetAllUnconfirmendQuestions();
            _questionNum = 0;
            GetQuestion(_questionNum);
        }

        private AdminQuestionsForm adminQuestionsForm;

        private void GetQuestion(int index)
        {
            Pnl_1.Controls.Clear();
            var question = _questionList[index];
            adminQuestionsForm = new AdminQuestionsForm(question);
            adminQuestionsForm.TopLevel = false;
            adminQuestionsForm.AutoSize = false;
            this.Width = Pnd_TeacherInfo.Width + adminQuestionsForm.Width;
            this.Height = adminQuestionsForm.Height + 90;
            Pnl_1.Width = adminQuestionsForm.Width + 20;
            Pnl_1.Controls.Add(adminQuestionsForm);
            adminQuestionsForm.Show();
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            if (_questionNum < _questionList.Count - 1)
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
