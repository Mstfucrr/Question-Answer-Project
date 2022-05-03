using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Question_Answer.Questions;
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
            foreach (var answeredQuestion in AnsweredQuestionsList
                         .Where(answeredQuestion => questionid == answeredQuestion.AnsweredQuestionIds))
            {
                answeredQuestion.AnsweredQuestionDate = DateTime.Now;
                answeredQuestion.TrueOrFalse = false;
                mongoDB.UpdateRecord("Students",this.UserId,this);
            }
        }

        public class SubjectClass
        {
            public string QuestionSubject { get; set; }
            public bool TrueOrFalse { get; set; }
        }

        public List<SubjectClass> GetQuestionSubjects()
        {
            return AnsweredQuestionsList
                .Select(answeredQuestion => new SubjectClass()
                {
                    QuestionSubject = mongoDB.LoadRecordById<Question>("Questions", answeredQuestion.AnsweredQuestionIds).QuestionSubject, 
                    TrueOrFalse = answeredQuestion.TrueOrFalse
                }).ToList();
        }
    }
}
