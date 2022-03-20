using System.Windows.Forms;
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

            chart1.Series["DogruYanlisBos"].Points[0].Label = student.TrueCount.ToString();
            chart1.Series["DogruYanlisBos"].Points[1].Label = student.FalseCount.ToString();

            chart1.Series["DogruYanlisBos"].Points[0].YValues[0] = student.TrueCount;
            chart1.Series["DogruYanlisBos"].Points[1].YValues[0] = student.FalseCount;

            Lbl_Ad_Soyad.Text = student.Name + " " + student.Lastname;
            Lbl_Eposta.Text = student.Email;
            Lbl_KullaniciAdi.Text = student.Username;
            Lbl_SoruSayisi.Text = (student.TrueCount + student.FalseCount).ToString();
            Lbl_TestSayisi.Text = student.NumberOfQuiz.ToString();

        }

        private void btn_SinavOl_Click(object sender, System.EventArgs e)
        {
            QuizFrom quizFrom = new QuizFrom(student);
            quizFrom.Closed += (o, args) =>
            {
                var newdashboardfrom = new StudentDashboardForm(student);
                newdashboardfrom.Closed += (sender1, eventArgs) => this.Close();
                newdashboardfrom.Show();
                quizFrom.Hide();
            };
            quizFrom.Show();
            this.Hide();
        }

        private void Btn_Logout_Click(object sender, System.EventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.Closed += (o, args) => this.Close();
            userLoginForm.Show();
            this.Hide();
        }
    }
}
