using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.Questions;

namespace Question_Answer.user.TeacherForm
{
    public partial class TeacherOwnQuestionForm : KryptonForm
    {
        private readonly Question _question;
        public TeacherOwnQuestionForm(Question question)
        {
            InitializeComponent();
            this._question = question;
        }

        private void TeacherOwnQuestionForm_Load(object sender, System.EventArgs e)
        {
            Lbl_Soru.Text = _question.QuestionText;
            if (_question.Answers[0].TrueOrFalse)
                Lbl_Cvp1.BackColor = Color.GreenYellow;
            else if (_question.Answers[1].TrueOrFalse)
                Lbl_Cvp2.BackColor = Color.GreenYellow;
            else if (_question.Answers[2].TrueOrFalse)
                Lbl_Cvp3.BackColor = Color.GreenYellow;
            else if (_question.Answers[3].TrueOrFalse)
                Lbl_Cvp4.BackColor = Color.GreenYellow;
            else if (_question.Answers[4].TrueOrFalse) 
                Lbl_Cvp5.BackColor = Color.GreenYellow;


            Lbl_Cvp1.Text = _question.Answers[0].AnswerText;
            Lbl_Cvp2.Text = _question.Answers[1].AnswerText;
            Lbl_Cvp3.Text = _question.Answers[2].AnswerText;
            Lbl_Cvp4.Text = _question.Answers[3].AnswerText;
            Lbl_Cvp5.Text = _question.Answers[4].AnswerText;
            if (_question.AdminAccept)
            {
                Lbl_AdminOnay.Text = "Onaylandı";
                Lbl_AdminOnay.ForeColor = Color.GreenYellow;
            }
            else
            {
                Lbl_AdminOnay.Text = "Onaylanmadı";
                Lbl_AdminOnay.ForeColor = Color.Red;
            }

            if (_question.QuestionImage != "")
            {
                pictureBox1.ImageLocation = _question.QuestionImage != null
                    ? _question.QuestionImagesUploadLocation + @"\" + _question.QuestionImage
                    : null;
            }
        }
    }
}
