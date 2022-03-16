using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using Question_Answer.user.UserClasses;

namespace Question_Answer.Questions.QuestionForms
{
    public partial class QuestionGetForm : Form
    {
        public List<Question> RandomQuestionList;
        public int index;
        public Student student;
        private int _thisQuestionTrueAnswerCount;
        private int _thisQuestionFalseAnswerCount;
        private Question randomQuestion;
        private RadioButton radioCevap;
        private IsaretlenenCevaplarListesi studentCevaplarListesi;

        public QuestionGetForm(Student student)
        {
            InitializeComponent();
            RandomQuestionList = new Question().Rastgele10SoruGetir<Question>();
            index = 0;
            _thisQuestionTrueAnswerCount = 0;
            _thisQuestionFalseAnswerCount = 0;

            studentCevaplarListesi = new IsaretlenenCevaplarListesi();
            QuestionGetFunction(index);
            CvpPanel.Visible = true;
            this.student = student;


            // yeni panel yan optik
            for (int i = 0; i < RandomQuestionList.Count; i++)
            {
                var questionpanel = OptikIcinPanelOlustur(RandomQuestionList[i].QuestionId, i % 2 == 1 ? Color.Turquoise : Color.Aquamarine);
                for (int j = 0; j < 5; j++)
                {
                    questionpanel.Controls.Add(OptikIcinRadioButtonOlustur(RandomQuestionList[i].Answers[j], j));
                }
            }

            //////////////////////////


        }

        //side bar için panel
        private Panel OptikIcinPanelOlustur(ObjectId questionId, Color color)
        {
            var pnl = new Panel
            {
                Width = panel2.Width,
                Height = panel4.Height,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = color,
                Name = questionId.ToString()
            };

            pnl.Top += (panel2.Controls.Count - 1) * panel4.Height;
            panel2.Controls.Add(pnl);
            return pnl;

        }

        private RadioButton OptikIcinRadioButtonOlustur(Answers opAnswers, int j)
        {
            var rBtn = new RadioButton
            {
                CheckAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Right,
                Location = new Point(j * panel2.Width / 5, 0),
                Size = new Size(panel2.Width / 5, 82),
                Name = "optik_" + opAnswers.AnswerId,
                TabStop = true,
                TextAlign = ContentAlignment.MiddleCenter,
                UseVisualStyleBackColor = true
            };
            return rBtn;
        }

        private List<RadioButton> CevapSecenekleriOlustur(List<Answers> answersList)
        {
            var RadioButtonList = new List<RadioButton>();
            foreach (var answer in answersList)
            {
                radioCevap = new RadioButton
                {
                    BackColor = Color.White,
                    Dock = DockStyle.Bottom,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    Location = new Point(0, 6),
                    Margin = new Padding(0),
                    MaximumSize = new Size(700, 123),
                    Name = answer.AnswerId.ToString(),
                    Size = new Size(700, 50),
                    Text = answer.AnswerText,
                    TabIndex = 2,
                    UseVisualStyleBackColor = false,
                };
                radioCevap.CheckedChanged += radioBtnsCheckedChanged;
                CvpPanel.Controls.Add(radioCevap);
                RadioButtonList.Add(radioCevap);
            }

            return RadioButtonList;



        }

        private string _trueAnswer = "";
        private void btn_DigerSoru_Click(object sender, EventArgs e)
        {
            if (index < RandomQuestionList.Count - 1)
                index++;
            QuestionGetFunction(index);

        }
        private void btn_OncekiSoru_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            QuestionGetFunction(index);

        }

        private void QuestionGetFunction(int index)
        {

            while (index >= RandomQuestionList.Count)
            {
                if (index > 0)
                    index--;
                else
                {
                    student.TrueCount += _thisQuestionTrueAnswerCount;
                    student.FalseCount += _thisQuestionFalseAnswerCount;

                    MessageBox.Show($"Sınav Bitti!\nBu sınavın" +
                                    $"\n  Doğru cevap sayısı : {_thisQuestionTrueAnswerCount}" +
                                    $"\n  Yanlış cevap sayısı : {_thisQuestionFalseAnswerCount}");
                    this.Close();
                    return;
                }

            }

            randomQuestion = RandomQuestionList[index];

            foreach (var randomQuestionAnswer in randomQuestion.Answers.Where(randomQuestionAnswer =>
                         randomQuestionAnswer.TrueOrFalse))
            {
                _trueAnswer = randomQuestionAnswer.AnswerText; // Doğru cevabın texti
            }

            foreach (var radioButton in CevapSecenekleriOlustur(randomQuestion.Answers))
            {
                CvpPanel.Controls.Add(radioButton);
            }


            foreach (var radioButton in CvpPanel.Controls.OfType<RadioButton>())
            {
                for (var ındex = 0; ındex < studentCevaplarListesi.İIsaretlenenCevapClasses.Count; ındex++)
                {
                    var randomQuestionAnswer = studentCevaplarListesi.İIsaretlenenCevapClasses[ındex];
                    if (randomQuestionAnswer.AnsweId.ToString() == radioButton.Name)
                    {
                        radioButton.Checked = true;
                    }
                }
            }


            Lbl_Soru.Text = randomQuestion.QuestionText;

            pictureBox1.ImageLocation = randomQuestion.QuestionImage != null
                ? randomQuestion.QuestionImagesUploadLocation + @"\" + randomQuestion.QuestionImage
                : null;
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {

            //foreach (var cntrl in Controls)
            //{
            //    if (cntrl is RadioButton { Checked: true } b)
            //    {
            //        if (b.Text == _trueAnswer)
            //        {
            //            MessageBox.Show(@"Cevabınız doğru tebrikler");
            //            _thisQuestionTrueAnswerCount++;
            //            student.AnsweredQuestionsList.Add(new AnsweredQuestions
            //            {
            //                TrueOrFalse = true,
            //                AnsweredQuestionIds = randomQuestion.QuestionId,
            //                AnsweredQuestionDate = DateTime.Now
            //            });

            //        }
            //        else
            //        {
            //            MessageBox.Show(@"Cevabınız hatalı");
            //            _thisQuestionFalseAnswerCount++;
            //            student.AnsweredQuestionsList.Add(new AnsweredQuestions
            //            {
            //                TrueOrFalse = false,
            //                AnsweredQuestionIds = randomQuestion.QuestionId,
            //                AnsweredQuestionDate = DateTime.Now
            //            });
            //        }


            //    }
            //}

            //RandomQuestionList.Remove(randomQuestion);
            //if (RandomQuestionList.Count == 1)
            //{
            //    btn_DigerSoru.Enabled = false;
            //    btn_OncekiSoru.Enabled = false;
            //}
            //QuestionGetFunction(index);

            //student.Save();

        }


        private void radioBtnsCheckedChanged(object sender, EventArgs e)
        {
            var isaretlenenCevap = sender as RadioButton;

            var isCevapClass = new IsaretlenenCevapClass();
            if (isaretlenenCevap is { Checked: true })
            {
                isCevapClass.AnsweId = new ObjectId(isaretlenenCevap.Name);
                studentCevaplarListesi.İIsaretlenenCevapClasses.Add(isCevapClass);

                foreach (var panel in panel2.Controls.OfType<Panel>())
                {
                    if (panel.Name == randomQuestion.QuestionId.ToString())
                        foreach (var radio in panel.Controls.OfType<RadioButton>())
                        {
                            if (radio.Name == "optik_" + isCevapClass.AnsweId)
                            {
                                radio.Checked = true;
                            }
                        }
                }
            }

            if (!isaretlenenCevap.Checked)
            {
                studentCevaplarListesi.İIsaretlenenCevapClasses.Remove(isCevapClass);
            }
        }
    }
}
