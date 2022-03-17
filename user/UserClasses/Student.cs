using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Question_Answer.user.UserClass;

namespace Question_Answer.user.UserClasses
{
    public class Student : User
    {
        [BsonElement("TrueCount")]
        public int TrueCount { get; set; }
        [BsonElement("FalseCount")]
        public int FalseCount { get; set; }

        [BsonElement("AnsweredQuestionsList")]
        public List<AnsweredQuestions> AnsweredQuestionsList;

        public Student Login(string KullaniciAdi, string Parola)
        {
            return mongoDB.LoadRecordByFilter<Student>("Students", new BsonDocument
            {
                { "Username", KullaniciAdi },
                { "Password", Parola }
            }).FirstOrDefault();
        }

        public void Save()
        {
            mongoDB.UpdateRecord("Students", this.UserId, this);
        }
    }
}
