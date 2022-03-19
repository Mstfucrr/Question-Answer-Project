using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Question_Answer.user.UserClasses
{
    public class AnsweredQuestions
    {
        [BsonElement("TrueOrFalse")]
        public bool TrueOrFalse { get; set; }

        [BsonElement("AnsweredQuestionIds")]
        public ObjectId AnsweredQuestionIds;

        [BsonElement("QuestionAnswederDate")]
        public DateTime AnsweredQuestionDate;
    }
}
