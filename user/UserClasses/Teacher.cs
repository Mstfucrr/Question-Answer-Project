using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Question_Answer.user.UserClass;

namespace Question_Answer.user.UserClasses
{
    internal class Teacher : User
    {
        [BsonElement("AddedQuestionsIds")]
        public List<ObjectId> AddedQuestionsIds { get; set; }
        [BsonElement("AddedQuestionCount")]
        public int AddedQuestionCount { get; set; }


        public Teacher Login(string KullaniciAdi, string Parola)
        {
            
            return mongoDB.LoadRecordByFilter<Teacher>("Teachers", new BsonDocument
            {
                { "Username", KullaniciAdi },
                { "Password", Parola }
            }).FirstOrDefault();
        }

        public void Save()
        {
            mongoDB.UpdateRecord("Teachers", this.UserId, this);
        }

    }
}
