using System.Windows.Forms;
using Question_Answer.Questions.QuestionForms;
using Question_Answer.user.UserForms;

namespace Question_Answer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //var db = new Database.MongoDB("Question-Answer-Database");
            //var user = db.LoadRecordByUsername_password<User>("User", "Mstfucrr", "123123");
            //user.Name = "Muhammet Mustafa";
            //db.UpdateRecord("User",user.KullaniciId,user);
        }

        private void btn_SoruEkle_Click(object sender, System.EventArgs e)
        {
            QuestionAddForm frm = new QuestionAddForm();
            frm.Show();
        }

        private void btn_KayitOl_Click(object sender, System.EventArgs e)
        {
            UserRegisterForm frm = new UserRegisterForm();
            frm.Show();
        }

        private void btn_GirisYap_Click(object sender, System.EventArgs e)
        {
            UserLoginForm frm = new UserLoginForm();
            frm.Show();
        }

        private void btn_SoruGetir_Click(object sender, System.EventArgs e)
        {
            //QuestionGetForm frm = new QuestionGetForm();
            //frm.Show();
        }
    }
}
