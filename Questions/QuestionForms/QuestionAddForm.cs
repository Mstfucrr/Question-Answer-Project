using System;
using System.IO;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.user.UserClasses;

namespace Question_Answer.Questions.QuestionForms
{
    public partial class QuestionAddForm : KryptonForm
    {
        private readonly Teacher adderTeacher;
        public QuestionAddForm(Teacher adderTeacher)
        {
            InitializeComponent();
            this.adderTeacher = adderTeacher;
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textSure.Text);
            }
            catch
            {
                MessageBox.Show(@"Lütfen süreyi kontrol ediniz 
sayı türünde olduğuna emin olunuz.");
                return;
            }

            if (textSoru.Text.Length == 0)
            {
                MessageBox.Show(@"Soru kutucuğu boş!!!");
            }

            var question = new Question
            {
                AdderTeacherId = adderTeacher.UserId,
                QuestionUnit = textUnite.Text,
                QuestionSubject = textKonu.Text,
                QuestionText = textSoru.Text,
                QuestionTime = Convert.ToInt32(textSure.Text)
            };
            question.Answers.Add(new Answers(radioButton1.Checked, textCevap1.Text));
            question.Answers.Add(new Answers(radioButton2.Checked, textCevap2.Text));
            question.Answers.Add(new Answers(radioButton3.Checked, textCevap3.Text));
            question.Answers.Add(new Answers(radioButton4.Checked, textCevap4.Text));
            question.Answers.Add(new Answers(radioButton5.Checked, textCevap5.Text));
            question.Save();
            if (ImageLocation.Length != 0)
            {
                question.QuestionImage = $"Image_{question.QuestionId}." + Path.GetFileName(ImageLocation).Split('.')[1];
                File.Copy(ImageLocation,
                    Path.Combine(question.QuestionImagesUploadLocation, question.QuestionImage), true);
                question.UpdateImage();
            }
            adderTeacher.AddedQuestionsIds.Add(question.QuestionId);
            adderTeacher.AddedQuestionCount += 1;
            adderTeacher.Update("Teachers");
            MessageBox.Show(@"Soru başarıyla kaydedildi");
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
