using System;
using System.IO;
using System.Windows.Forms;

namespace Question_Answer.Questions.QuestionForms
{
    public partial class QuestionAddForm : Form
    {
        public QuestionAddForm()
        {
            InitializeComponent();

        }


        public Database.MongoDB db = new Database.MongoDB();

        private void btn_kaydet_Click(object sender, System.EventArgs e)
        {

            foreach (var cntrl in this.Controls)
            {
                if (cntrl is TextBox box && box.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen tüm boşlukları doldurduğunuzdan \nve bir seçeneği doğru olarak işaretlediğinizden emin olun!");
                    return;
                }
            }
            
            Question question = new Question();
            question.QuestionText = textSoru.Text;
            question.Answers.Add(new Answers(radioButton1.Checked, textCevap1.Text));
            question.Answers.Add(new Answers(radioButton2.Checked, textCevap2.Text));
            question.Answers.Add(new Answers(radioButton3.Checked, textCevap3.Text));
            question.Answers.Add(new Answers(radioButton4.Checked, textCevap4.Text));
            question.Answers.Add(new Answers(radioButton5.Checked, textCevap5.Text));
            db.InsertRecord("Questions", question);
            if (ImageLocation.Length != 0)
            {
                question.QuestionImage = $"Image_{question.QuestionId}." + Path.GetFileName(ImageLocation).Split('.')[1];
                File.Copy(ImageLocation,
                    Path.Combine(question.QuestionImagesUploadLocation,question.QuestionImage), true);
                db.UpdateRecord("Questions", question.QuestionId, question);
            }
            MessageBox.Show(@"QuestionText başarıyla kaydedildi");
        }

        private void QuestionAddForm_Load(object sender, EventArgs e)
        {
            
        }

        public string ImageLocation = "";
        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    ImageLocation = file;
                    pictureBox1.ImageLocation = ImageLocation;
                }
                catch (IOException)
                {
                }
            }
            
        }
    }
}
