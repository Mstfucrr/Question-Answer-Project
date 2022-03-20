using System.Collections.Generic;
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

        [BsonElement("NumberOfQuiz")]
        public int NumberOfQuiz { get; set; }


    }
}
