using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin.Controls;
using MongoDB.Bson;
using Question_Answer.user.StudentUserForm;
using Question_Answer.user.UserClasses;
using Timer = System.Windows.Forms.Timer;


namespace Question_Answer.Questions.QuestionForms
{
    public partial class QuizFrom : KryptonForm
    {
        private Question _randomQuestion;
        private Question _solvedQuestion;
        public List<Question> RandomQuestionList;
        public List<Question> CorrectlySolvedQuestionList;
        public Student Student;
        public int RandomQuestionNum;
        public int SolvedQuestionNum;
        private int _thisQuestionTrueAnswerCount;
        private int _thisQuestionFalseAnswerCount;
        private RadioButton _radioCevap;
        private readonly IsaretlenenCevaplarListesi _studentAnswerlist;
        private int _quizTime;
        private Timer _timer;
        public QuizFrom(Student student)
        {
            InitializeComponent();
            var getQuestion = new Question();
            RandomQuestionList = getQuestion.GetRandom10Qeustions();
            CorrectlySolvedQuestionList = getQuestion.GetQuestionsbyDay(student);

            while (!getQuestion.SameQuestionControl(RandomQuestionList, CorrectlySolvedQuestionList))
            // RandomQuestionList ile CorrectlySolvedQuestionList içindeki sorular çakışmayana kadar tekardan random 10 soru çeker
            {
                RandomQuestionList = getQuestion.GetRandom10Qeustions();
            }



            RandomQuestionNum = 0;
            SolvedQuestionNum = 0;
            _thisQuestionTrueAnswerCount = 0;
            _thisQuestionFalseAnswerCount = 0;

            _studentAnswerlist = new IsaretlenenCevaplarListesi();
            GetQuestion(RandomQuestionNum, true);
            this.Student = student;
            student.NumberOfQuiz += 1;

        }
        private void QuizFrom_Load(object sender, EventArgs e)
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += TimerOnTick;
            _timer.Start();
            this.Size = new Size(1000, 760);
            // Random quesiton listesi için panel yan optikleri
            for (var i = 0; i < RandomQuestionList.Count; i++)
            {
                var questionpanel = CreatePanelForOptic(RandomQuestionList[i].QuestionId, i % 2 == 1
                    ? Color.Turquoise : Color.Aquamarine, i + 1);
                for (var j = 0; j < RandomQuestionList[i].Answers.Count; j++) // soru cevap sayısı
                {
                    if (RandomQuestionList[i].Answers[j].AnswerText.Length != 0)
                        questionpanel.Controls.Add(CreateRadioButtonForOpticPanel(RandomQuestionList[i].Answers[j], j));

                }

                _quizTime += RandomQuestionList[i].QuestionTime;//sınav toplam süresi hesapla saniye
            }
            //////////////////////////
            //Daha önce çözülmüş sorular listesi için yan panel optikleri
            for (var i = 0; i < CorrectlySolvedQuestionList.Count; i++)
            {
                var questionpanel = CreatePanelForOptic(CorrectlySolvedQuestionList[i].QuestionId, i % 2 == 1
                    ? Color.Turquoise : Color.Aquamarine, RandomQuestionList.Count + i + 1);
                for (var j = 0; j < CorrectlySolvedQuestionList[i].Answers.Count; j++) // soru cevap sayısı
                {
                    if (CorrectlySolvedQuestionList[i].Answers[j].AnswerText.Length != 0)
                    {
                        questionpanel.Controls.Add(CreateRadioButtonForOpticPanel(CorrectlySolvedQuestionList[i].Answers[j], j));
                    }
                }

                _quizTime += CorrectlySolvedQuestionList[i].QuestionTime;//sınav toplam süresi hesapla saniye
            }
            //////////////////////////
        }

        private void TimerOnTick(object sender, EventArgs e)
        {

            if (_quizTime > 0)
            {
                _quizTime--;
                TimeSpan secToTimeSpan = TimeSpan.FromSeconds(_quizTime);
                txtTime.Text = $@"{secToTimeSpan.Hours}:{secToTimeSpan.Minutes}:{secToTimeSpan.Seconds}";
                if (_quizTime < 10)
                {
                    txtTime.BackColor = Color.Red;
                    txtTime.ForeColor = Color.White;
                }
            }
            else
            {
                _timer.Stop();
                MessageBox.Show("Süre doldu !!!");
                QuizFinished(RandomQuestionList, true);
                QuizFinished(CorrectlySolvedQuestionList, false);

            }
        }

        private Panel CreatePanelForOptic(ObjectId questionId, Color color, int question_count)//Optir bar için panel
        {
            var pnl = new Panel
            {
                Width = optikPanel.Width,
                Height = 84,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = color,
                Name = questionId.ToString()
            };
            var lbl = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                Location = new Point(2, 0),
                Name = "label"+question_count,
                Size = new Size(24, 17),
                TabIndex = 0,
                Text = question_count+ " )",
            };

            pnl.Top += (optikPanel.Controls.Count - 1) * 84;
            optikPanel.Controls.Add(pnl);
            pnl.Controls.Add(lbl);
            return pnl;

        }

        private MaterialRadioButton CreateRadioButtonForOpticPanel(Answers opAnswers, int j)
        {
            var rBtn = new MaterialRadioButton();
            rBtn.CheckAlign = ContentAlignment.MiddleCenter;
            rBtn.Dock = DockStyle.Right;
            rBtn.Location = new Point(j * optikPanel.Width / 5-4, 0);
            rBtn.Size = new Size(optikPanel.Width / 5 + 4, 82);
            rBtn.Name = "optik_" + opAnswers.AnswerId;
            rBtn.TabStop = true;
            rBtn.TextAlign = ContentAlignment.MiddleCenter;
            rBtn.UseVisualStyleBackColor = true;
            rBtn.CheckedChanged += radioBtnsCheckedChanged;

            return rBtn;
        }

        private void CreateOtionsforAnswers(List<Answers> answersList)
        { 
            var RadioButtonList = new List<RadioButton>();
            foreach (var answer in answersList
                         .Where(answer => answer.AnswerText.Length != 0))
            {
                _radioCevap = new RadioButton();
                _radioCevap.BackColor = Color.White;
                
                //_radioCevap.Dock = DockStyle.Bottom;
                _radioCevap.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                _radioCevap.Location = new Point(0, OptionsPanel.Controls.Count * 50);
                _radioCevap.Margin = new Padding(0);
                _radioCevap.Name = answer.AnswerId.ToString();
                _radioCevap.Size = new Size(550, 60);
                _radioCevap.AutoSize = false;
                _radioCevap.TabIndex = 2;
                _radioCevap.UseVisualStyleBackColor = false;
                _radioCevap.CheckedChanged += radioBtnsCheckedChanged;
                _radioCevap.Text = answer.AnswerText;
                _radioCevap.AutoSize = false;
                OptionsPanel.Controls.Add(_radioCevap);
                RadioButtonList.Add(_radioCevap);
                if (_timer is { Enabled: false } && answer.TrueOrFalse)
                {
                    _radioCevap.BackColor = Color.Chartreuse;
                }
            }
        }

        private void btn_DigerSoru_Click(object sender, EventArgs e)
        {
            if (RandomQuestionNum < RandomQuestionList.Count - 1)
            {
                RandomQuestionNum++;
                GetQuestion(RandomQuestionNum, true);

            }
            else if (SolvedQuestionNum < CorrectlySolvedQuestionList.Count - 1)
            {
                SolvedQuestionNum++;
                GetQuestion(SolvedQuestionNum, false);
            }
        }
        private void btn_OncekiSoru_Click(object sender, EventArgs e)
        {
            if (SolvedQuestionNum > 0)
            {
                SolvedQuestionNum--;
                GetQuestion(SolvedQuestionNum, false);
            }
            else if (RandomQuestionNum > 0)
            {
                RandomQuestionNum--;
                GetQuestion(RandomQuestionNum, true);

            }


        }
        private void GetQuestion(int index, bool isRandomQuestionList)
        {
            if (isRandomQuestionList)
            {
                _randomQuestion = RandomQuestionList[index];
                OptionsPanel.Controls.Clear();
                CreateOtionsforAnswers(_randomQuestion.Answers);
                Lbl_Soru.Text = (index + 1) + " ) " + _randomQuestion.QuestionText;

                pictureBox1.ImageLocation = _randomQuestion.QuestionImage != null
                    ? _randomQuestion.QuestionImagesUploadLocation + @"\" + _randomQuestion.QuestionImage
                    : null;
            }
            else
            {
                _solvedQuestion = CorrectlySolvedQuestionList[index];
                OptionsPanel.Controls.Clear();
                CreateOtionsforAnswers(_solvedQuestion.Answers);
                Lbl_Soru.Text = (10 + index + 1) + " ) " + _solvedQuestion.QuestionText;

                pictureBox1.ImageLocation = _solvedQuestion.QuestionImage != null
                    ? _solvedQuestion.QuestionImagesUploadLocation + @"\" + _solvedQuestion.QuestionImage
                    : null;
            }

            ///////////////////////////
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
            ///////////////////////////

        }


        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            QuizFinished(CorrectlySolvedQuestionList, false);
            QuizFinished(RandomQuestionList, true);
            _timer.Stop();
            StudentQuizInfoUpdate();
        }

        private void StudentQuizInfoUpdate()
        {
            Student.TrueCount += _thisQuestionTrueAnswerCount;
            Student.FalseCount += _thisQuestionFalseAnswerCount;
            Student.Update("Students");
            MessageBox.Show("Bu testin " +
                            $"\nDoğru cevap sayısı : {_thisQuestionTrueAnswerCount}" +
                            $"\nYanlış cevap sayısı : {_thisQuestionFalseAnswerCount}");
            optikPanel.Enabled = false;
            OptionsPanel.Enabled = false;

        }

        private void QuizFinished(List<Question> denetlemeQuestions, bool isRandomQuestionlistElement)
        {
            foreach (var questionListElement in denetlemeQuestions) // öğrenciye gösterilen sorular listesi foreach'ı
            {
                foreach (var selectedAnswerIdListElement in _studentAnswerlist.SelectedAnswerIdList) // öğrencinin işaretlediği cevaplar
                {
                    foreach (var questionListAnswerElement in questionListElement.Answers)// öğrenciye gösterilen soruların cevaplar listesi foreach'ı
                    {
                        if (selectedAnswerIdListElement == questionListAnswerElement.AnswerId) // öğrencinin işaretlediği cevabın idsi ile gösterilen soruların cevap idsi ni karşılaştırma
                        {
                            foreach (Control optikPanelControl in optikPanel.Controls) // optik panel foreach'ı
                            {
                                if (optikPanelControl.Name == questionListElement.QuestionId.ToString())
                                {
                                    if (questionListAnswerElement.TrueOrFalse)
                                    //eğer liste random listesi değilse o çözülmüş soruların içinde vardır o zaman eklenmesine veya tarihinin güncellenmesine gerek yok
                                    {
                                        optikPanelControl.BackColor = Color.Chartreuse;
                                        _thisQuestionTrueAnswerCount++;
                                        if (isRandomQuestionlistElement)
                                        {
                                            Student.AnsweredQuestionsList.Add(new AnsweredQuestion
                                            {
                                                TrueOrFalse = true,
                                                AnsweredQuestionIds = questionListElement.QuestionId,
                                                AnsweredQuestionDate = DateTime.Now // random sorular için date time olmalı

                                            });

                                        }


                                    }
                                    else
                                    {
                                        optikPanelControl.BackColor = Color.Red;
                                        _thisQuestionFalseAnswerCount++;
                                        if (isRandomQuestionlistElement)
                                        {
                                            Student.AnsweredQuestionsList.Add(new AnsweredQuestion
                                            {
                                                TrueOrFalse = false,
                                                AnsweredQuestionIds = questionListElement.QuestionId,
                                                AnsweredQuestionDate = DateTime.Now
                                            });
                                        }
                                        else
                                        {
                                            Student.QuestionUpdate(questionListElement.QuestionId);
                                            // eğer liste random listesi değilse o çözülmüş soruların içinde vardır 
                                            // bu yüzden eklemek yerine güncellemek gerekir.
                                        }

                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        public void radioBtnsCheckedChanged(object sender, EventArgs e)
        {
            var selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton is { Checked: false })
            {
                _studentAnswerlist.SelectedAnswerIdList.Remove(selectedRadioButton.Text == ""
                    ? new ObjectId(selectedRadioButton.Name.Split('_')[1])
                    : new ObjectId(selectedRadioButton.Name));
            }
            if (selectedRadioButton is { Checked: true })
            {
                var ısaretlenenCevapId = (selectedRadioButton.Text == ""
                    ? new ObjectId(selectedRadioButton.Name.Split('_')[1])
                    : new ObjectId(selectedRadioButton.Name));

                if (_studentAnswerlist.SelectedAnswerIdList.Count == 0)
                {
                    _studentAnswerlist.SelectedAnswerIdList.Add(ısaretlenenCevapId);
                }

                //Aynı answerid eklememek için döngü
                var confirmation = _studentAnswerlist.SelectedAnswerIdList.All(objectId => ısaretlenenCevapId != objectId);

                if (confirmation)
                    _studentAnswerlist.SelectedAnswerIdList.Add(ısaretlenenCevapId);

                foreach (var panel in optikPanel.Controls.OfType<Panel>())//optik panel
                {
                    if (panel.Name == _randomQuestion.QuestionId.ToString())//optik panel içindeki soru id ile görüntülenen soru id karşılaştırma
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
