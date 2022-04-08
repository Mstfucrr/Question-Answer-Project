using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Question_Answer.user.UserClasses;

namespace Question_Answer.Questions
{
    public class Question
    {
        [BsonId]
        private ObjectId Id { get; set; }
        public ObjectId QuestionId => Id;
        [BsonElement("QuestionText")]
        public string QuestionText { get; set; }
        [BsonElement("QuestionImage")]
        public string QuestionImage { get; set; }
        [BsonElement("Answers")]
        public List<Answers> Answers;

        [BsonElement("AdminAccept")]
        public bool AdminAccept { get; set; }

        [BsonElement("AdderTeacherId")]
        public ObjectId AdderTeacherId;

        [BsonElement("QuestionUnit")]
        public string QuestionUnit { get; set; }

        [BsonElement("QuestionSubject")]
        public string QuestionSubject { get; set; }

        [BsonElement("QuestionTime")]
        public int QuestionTime { get; set; }

        [BsonIgnore]
        private Database.MongoDB mongoDB;
        [BsonIgnore]
        public static string GetDirectoryName = Path.GetDirectoryName(Application.ExecutablePath);
        [BsonIgnore]
        public string QuestionImagesUploadLocation = GetDirectoryName.Remove(GetDirectoryName.Length - (@"\bin\Debug").Length) + @"\Images\QuestionImagesUpload";


        public Question()
        {
            Answers = new List<Answers>();
            mongoDB = new Database.MongoDB();
        }

        public void Save()
        {
            mongoDB.InsertRecord("Questions", this);
        }

        public void Update()
        {
            mongoDB.UpdateRecord("Questions", this.QuestionId, this);
        }

        public bool SameQuestionControl(List<Question> list1,List<Question> list2)
        {
            var AllGetQuestionList = new List<Question>();
            foreach (var random10Qeustion in list1)
            {
                AllGetQuestionList.Add(random10Qeustion);   
            }

            foreach (var question in list2)
            {
                AllGetQuestionList.Add(question);
            }

            AllGetQuestionList.Distinct();
            return AllGetQuestionList.Count == list1.Count + list2.Count; 
            // tüm sorulucak sorular == daha önce doğru cevapladığı sorular + rastgele 10 soru TRUE döndürür
        }


        public List<Question> GetRandom10Qeustions()
        {
            var questions = mongoDB.RandomQuestionsWithFilter();
            return questions.ToList();
        }

        public List<Question> GetQuestionsbyDay(Student student)
        {
            var QuestionbyDay = new List<Question>();
            foreach (var answeredQuestion in student.AnsweredQuestionsList)
            {
                if (answeredQuestion.TrueOrFalse)
                {
                    var day = (DateTime.Now - answeredQuestion.AnsweredQuestionDate).Days;
                    if (day is 1 or 7 or 30 or 180 or 365)
                    {
                        
                        QuestionbyDay.Add(mongoDB.LoadRecordByFilter<Question>("Questions",new BsonDocument
                        {
                            { "AdminAccept", true },
                            { "id" , answeredQuestion.AnsweredQuestionIds}
                        }).First());
                    }
                }
            }

            return QuestionbyDay;
        }

    }
}
