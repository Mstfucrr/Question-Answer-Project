using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.Questions.QuestionForms;
using Question_Answer.user.UserClasses;
using Question_Answer.user.UserForms;

namespace Question_Answer.user.StudentUserForm
{
    public partial class StudentDashboardForm : KryptonForm
    {
        private Student student;
        public StudentDashboardForm(Student student)
        {
            InitializeComponent();
            this.student = student;
        }


        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {

            chart1.Series["DogruYanlis"].Points[0].Label = student.TrueCount.ToString();
            chart1.Series["DogruYanlis"].Points[1].Label = student.FalseCount.ToString();
            chart1.Series["DogruYanlis"].Points[0].YValues[0] = student.TrueCount;
            chart1.Series["DogruYanlis"].Points[1].YValues[0] = student.FalseCount;

            var SubjectList = student.GetQuestionSubjects();

            var ChartSubjectList = new List<string>();
            foreach (var Subject in SubjectList
                         .Where(Subject => !ChartSubjectList.Contains(Subject.QuestionSubject)))
            {
                ChartSubjectList.Add(Subject.QuestionSubject);
            }

            foreach (var subjstr in ChartSubjectList)
            {
                var TrueCount = 0;
                var FalseCount = 0;
                foreach (var subjectClass in SubjectList
                    .Where(subjectClass => subjectClass.QuestionSubject == subjstr))
                {
                    if (subjectClass.TrueOrFalse)
                        TrueCount++;
                    else
                        FalseCount++;
                }

                chart2.Series["DogruSayisi"].Points.AddXY(subjstr, TrueCount);
                chart2.Series["YanlisSayisi"].Points.AddXY(subjstr, FalseCount);
                
            }

            Lbl_Ad_Soyad.Text = student.Name + " " + student.Lastname;
            Lbl_Eposta.Text = student.Email;
            Lbl_KullaniciAdi.Text = student.Username;
            Lbl_SoruSayisi.Text = (student.TrueCount + student.FalseCount).ToString();
            Lbl_TestSayisi.Text = student.NumberOfQuiz.ToString();
        }

        private void btn_SinavOl_Click(object sender, EventArgs e)
        {
            QuizFrom quizFrom = new QuizFrom(student);
            quizFrom.Closed += (o, args) =>
            {
                var newdashboardfrom = new StudentDashboardForm(student);
                newdashboardfrom.Closed += (sender1, eventArgs) => Close();
                newdashboardfrom.Show();
                quizFrom.Hide();
            };
            quizFrom.Show();
            Hide();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Closed += (o, args) => Close();
            userLoginForm.Show();
            Hide();
        }
        protected void btn_Yazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            chart2.Printing.PrintPreview();
        }

        private void btn_QuestionDaySetting_Click(object sender, EventArgs e)
        {
            SetQuestionDayForm dayForm = new SetQuestionDayForm(student.UserId);
            dayForm.Show();
        }
    }
}
