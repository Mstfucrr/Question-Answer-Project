using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Question_Answer.Questions.QuestionClasses;
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

        public bool SameQuestionControl(List<Question> list1, List<Question> list2)
        {
            var AllGetQuestionList = list1.ToList();
            AllGetQuestionList.AddRange(list2);
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
            return (
                from answeredQuestion in student.AnsweredQuestionsList
                where answeredQuestion.TrueOrFalse
                    let day = (DateTime.Now - answeredQuestion.AnsweredQuestionDate).Days
                    let questionDayList = new QuestionDaySetting().GetQuestionDays(student.UserId)
                    where questionDayList.Contains(day)
                        select mongoDB.LoadRecordByFilter<Question>("Questions", 
                            new BsonDocument 
                                {
                                    {"AdminAccept", true},
                                    {"_id", answeredQuestion.AnsweredQuestionIds}}
                                )
                                    .First()).ToList();
        }

    }
}
