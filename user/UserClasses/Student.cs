using System;
using System.Collections.Generic;
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
        public List<AnsweredQuestion> AnsweredQuestionsList;

        [BsonElement("NumberOfQuiz")]
        public int NumberOfQuiz { get; set; }



        public void QuestionUpdate(ObjectId questionid)
        {
            foreach (var answeredQuestion in AnsweredQuestionsList)
            {
                if (questionid == answeredQuestion.AnsweredQuestionIds)
                {
                    answeredQuestion.AnsweredQuestionDate = DateTime.Now;
                    answeredQuestion.TrueOrFalse = false;
                    mongoDB.UpdateRecord("Students",this.UserId,this);

                }
            }
        }

    }
}
