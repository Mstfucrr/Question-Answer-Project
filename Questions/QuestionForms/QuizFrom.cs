using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using Question_Answer.user.StudentUserForm;
using Question_Answer.user.UserClasses;

namespace Question_Answer.Questions.QuestionForms
{
    public partial class QuizFrom : Form
    {
        public List<Question> RandomQuestionList;
        public int SoruNum;
        public Student student;
        private int _thisQuestionTrueAnswerCount;
        private int _thisQuestionFalseAnswerCount;
        private Question randomQuestion;
        private RadioButton radioCevap;
        private IsaretlenenCevaplarListesi _studentAnswerlist;

        public QuizFrom(Student student)
        {
            InitializeComponent();
            RandomQuestionList = new Question().Rastgele10SoruGetir<Question>();
            SoruNum = 0;
            _thisQuestionTrueAnswerCount = 0;
            _thisQuestionFalseAnswerCount = 0;

            _studentAnswerlist = new IsaretlenenCevaplarListesi();
            SorularıGetir(SoruNum);
            OptionsPanel.Visible = true;
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

        private Panel OptikIcinPanelOlustur(ObjectId questionId, Color color)//Optir bar için panel
        {
            var pnl = new Panel
            {
                Width = optikPanel.Width,
                Height = 84,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = color,
                Name = questionId.ToString()
            };

            pnl.Top += (optikPanel.Controls.Count - 1) * 84;
            optikPanel.Controls.Add(pnl);
            return pnl;

        }

        private RadioButton OptikIcinRadioButtonOlustur(Answers opAnswers, int j)
        {
            var rBtn = new RadioButton
            {
                CheckAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Right,
                Location = new Point(j * optikPanel.Width / 5, 0),
                Size = new Size(optikPanel.Width / 5, 82),
                Name = "optik_" + opAnswers.AnswerId,
                TabStop = true,
                TextAlign = ContentAlignment.MiddleCenter,
                UseVisualStyleBackColor = true,
            };
            rBtn.CheckedChanged += radioBtnsCheckedChanged;

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
                OptionsPanel.Controls.Add(radioCevap);
                RadioButtonList.Add(radioCevap);
            }

            return RadioButtonList;

        }

        private ObjectId _trueAnswerId;
        private void btn_DigerSoru_Click(object sender, EventArgs e)
        {
            if (SoruNum < RandomQuestionList.Count - 1)
                SoruNum++;
            SorularıGetir(SoruNum);

        }
        private void btn_OncekiSoru_Click(object sender, EventArgs e)
        {
            if (SoruNum > 0)
                SoruNum--;
            SorularıGetir(SoruNum);

        }

        private void SorularıGetir(int index)
        {


            randomQuestion = RandomQuestionList[index];
            OptionsPanel.Controls.Clear();
            foreach (var radioButton in CevapSecenekleriOlustur(randomQuestion.Answers))
                OptionsPanel.Controls.Add(radioButton);

            foreach (var radioButton in OptionsPanel.Controls.OfType<RadioButton>())
            {
                foreach (var randomQuestionAnswer in _studentAnswerlist.SelectedAnswerIdList)
                {
                    if (randomQuestionAnswer.ToString() == radioButton.Name && !radioButton.Checked)
                    {
                        radioButton.Checked = true;
                    }
                }
            }


            Lbl_Soru.Text = (index + 1) + " ) " + randomQuestion.QuestionText;

            pictureBox1.ImageLocation = randomQuestion.QuestionImage != null
                ? randomQuestion.QuestionImagesUploadLocation + @"\" + randomQuestion.QuestionImage
                : null;
        }


        private void btn_Onayla_Click(object sender, EventArgs e)
        {

            for (var index = 0; index < RandomQuestionList.Count; index++)// sorulan soru for'u
            {
                var questionListElement = RandomQuestionList[index];
                foreach (var SelectedAnswerIdListElement in _studentAnswerlist.SelectedAnswerIdList) // öğrencinin işaretlediği cevaplar
                {
                    foreach (var questionListAnswerElement in questionListElement.Answers)
                    {
                        if (SelectedAnswerIdListElement == questionListAnswerElement.AnswerId)
                        {
                            foreach (Control optikPanelControl in optikPanel.Controls)
                            {
                                if (optikPanelControl.Name == questionListElement.QuestionId.ToString())
                                {
                                    if (questionListAnswerElement.TrueOrFalse)
                                    {
                                        optikPanelControl.BackColor = Color.Chartreuse;
                                        _thisQuestionTrueAnswerCount++;
                                        student.AnsweredQuestionsList.Add(new AnsweredQuestions
                                        {
                                            TrueOrFalse = true,
                                            AnsweredQuestionIds = questionListElement.QuestionId,
                                            AnsweredQuestionDate = DateTime.Now

                                        });
                                    }
                                    else
                                    {
                                        optikPanelControl.BackColor = Color.Red;
                                        _thisQuestionFalseAnswerCount++;
                                        student.AnsweredQuestionsList.Add(new AnsweredQuestions
                                        {
                                            TrueOrFalse = false,
                                            AnsweredQuestionIds = questionListElement.QuestionId,
                                            AnsweredQuestionDate = DateTime.Now
                                        });
                                    }
                                }
                            }

                        }
                    }
                }
            }
            student.TrueCount += _thisQuestionTrueAnswerCount;
            student.FalseCount += _thisQuestionFalseAnswerCount;
            student.Save();
            MessageBox.Show("Bu testin " +
                            $"\nDoğru cevap sayısı : {_thisQuestionTrueAnswerCount}" +
                            $"\nYanlış cevap sayısı : {_thisQuestionFalseAnswerCount}");
            optikPanel.Enabled = false;
            OptionsPanel.Enabled = false;
            StudentDashboardForm dashboardForm = new StudentDashboardForm(student);
            dashboardForm.Show();
            //btn_Onayla.Enabled = false;

        }

        public void radioBtnsCheckedChanged(object sender, EventArgs e)
        {
            var SelectedRadioButton = sender as RadioButton;

            if (SelectedRadioButton is { Checked: false })
            {
                _studentAnswerlist.SelectedAnswerIdList.Remove(SelectedRadioButton.Text == ""
                    ? new ObjectId(SelectedRadioButton.Name.Split('_')[1])
                    : new ObjectId(SelectedRadioButton.Name));
            }
            if (SelectedRadioButton is { Checked: true })
            {
                var ısaretlenenCevapId = (SelectedRadioButton.Text == ""
                    ? new ObjectId(SelectedRadioButton.Name.Split('_')[1])
                    : new ObjectId(SelectedRadioButton.Name));

                if (_studentAnswerlist.SelectedAnswerIdList.Count == 0)
                {
                    _studentAnswerlist.SelectedAnswerIdList.Add(ısaretlenenCevapId);
                }

                //Aynı answerid eklememek için döngü
                var confirmation = true;
                for (var ındex = 0; ındex < _studentAnswerlist.SelectedAnswerIdList.Count; ındex++)
                {
                    var objectId = _studentAnswerlist.SelectedAnswerIdList[ındex];
                    if (ısaretlenenCevapId == objectId) // son eleman
                    {
                        confirmation = false;
                        break;
                    }
                }

                if (confirmation)
                {
                    _studentAnswerlist.SelectedAnswerIdList.Add(ısaretlenenCevapId);

                }

                foreach (var panel in optikPanel.Controls.OfType<Panel>())//optik panel
                {
                    if (panel.Name == randomQuestion.QuestionId.ToString())//optik panel içindeki soru id ile görüntülenen soru id karşılaştırma
                    {
                        foreach (var radio in panel.Controls.OfType<RadioButton>()) // optik panel > soru id panel > radiobuttonlar
                        {
                            if (radio.Name == "optik_" + ısaretlenenCevapId)
                            {
                                radio.Checked = true;

                            }
                        }
                    }
                }
            }
        }
    }
}
