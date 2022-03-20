using System;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.Questions;
using Question_Answer.user.UserClasses;

namespace Question_Answer.user.AdminForm
{
    public partial class AdminQuestionsForm : KryptonForm
    {
        private Question _question;
        public AdminQuestionsForm(Question question)
        {
            InitializeComponent();
            this._question = question;
        }

        private void AdminQuestionsForm_Load(object sender, EventArgs e)
        {
            Btn_Confirm.Visible = !_question.AdminAccept;



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

            if (_question.QuestionImage != "")
            {
                pictureBox1.ImageLocation = _question.QuestionImage != null
                    ? _question.QuestionImagesUploadLocation + @"\" + _question.QuestionImage
                    : null;
            }
            
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ConfirmQuestion(_question);
        }
    }
}
