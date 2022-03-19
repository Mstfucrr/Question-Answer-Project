using System.Windows.Forms;
using Question_Answer.Questions.QuestionForms;
using Question_Answer.user.UserClasses;

namespace Question_Answer.user.StudentUserForm
{
    public partial class StudentDashboardForm : Form
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

            lbl_Ad.Text = student.Name;
            lbl_Soyad.Text = student.Lastname;
            lbl_Eposta.Text = student.Email;
            lbl_KullaniciAdi.Text = student.Username;

        }

        private void btn_SinavOl_Click(object sender, System.EventArgs e)
        {
            QuizFrom questionGetForm = new QuizFrom(student);
            questionGetForm.Closed += (o, args) => this.Close();
            questionGetForm.Show();
            this.Hide();
        }
    }
}
