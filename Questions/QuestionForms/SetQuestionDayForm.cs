using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Question_Answer.Questions.QuestionClasses;

namespace Question_Answer.Questions.QuestionForms
{
    public partial class SetQuestionDayForm : KryptonForm
    {
        public QuestionDaySetting questionDaySetting = new QuestionDaySetting();

        public SetQuestionDayForm()
        {
            InitializeComponent();
        }

        private void SetQuestionDayForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var questionDay in questionDaySetting.GetQuestionDays())
                listBox1.Items.Add(questionDay.ToString());


        }

        private void btn_DaysUpdate_Click(object sender, EventArgs e)
        {
            var days = new List<int>();

            foreach (var listBox1Item in listBox1.Items)
            {
                try
                {
                    var intday = Convert.ToInt32(listBox1Item.ToString());
                    if (intday > 0)
                    {
                        days.Add(intday);
                    }
                    else
                    {
                        MessageBox.Show(@"Geçersiz zaman");
                        return;
                    }
                }
                catch
                { // ignored
                    MessageBox.Show(@"Geçersiz zaman");
                    return;
                }
            }
            questionDaySetting.SetQuestionDays(days);
            MessageBox.Show(@"Süreler güncellendi");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textUpdate.Enabled = true;
            btn_dayUpdate.Enabled = true;
            if (listBox1.SelectedItem != null)
                textUpdate.Text = listBox1.SelectedItem.ToString();
        }

        private void btn_DaysAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textAdd.Text);
            textAdd.Text = "";
        }

        private void btn_dayUpdate_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show(@"Lütfen bir gün seçiniz");
            }
            else
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, textUpdate.Text);
                textUpdate.Text = "";
            }
            
        }

        private void btn_dayDelete_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
        }
    }
}
