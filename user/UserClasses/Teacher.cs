using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Question_Answer.Questions;
using Question_Answer.user.UserClass;

namespace Question_Answer.user.UserClasses
{
    public class Teacher : User
    {
        [BsonElement("AddedQuestionsIds")]
        public List<ObjectId> AddedQuestionsIds { get; set; }
        [BsonElement("AddedQuestionCount")]
        public int AddedQuestionCount { get; set; }
        
        public List<Question> GetAddedQuestions()
        {
            return AddedQuestionsIds
                .Select(addedQuestionsId => mongoDB.LoadRecordById<Question>("Questions", addedQuestionsId))
                .ToList();
        }


    }
}
