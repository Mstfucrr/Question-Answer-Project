using System.Collections.Generic;
using MongoDB.Bson;
using Question_Answer.Questions;

namespace Question_Answer.user.UserClasses
{
    internal class AdminDashboard
    {

        private Database.MongoDB mongoDb;

        public AdminDashboard()
        {
            mongoDb = new Database.MongoDB();
        }

        public List<Student> GetAllStudents()
        {
            var collection = mongoDb.LoadRecords<Student>("Students");
            return collection;
        }
        public List<Teacher> GetAllTeachers()
        {
            var collection = mongoDb.LoadRecords<Teacher>("Teachers");
            return collection;
        }

        public List<Question> GetAllUnconfirmendQuestions()
        {
            var collection = mongoDb.LoadRecordByFilter<Question>("Questions", new BsonDocument
            {
                { "AdminAccept", false }
            });
        return collection;
        }

        public List<Question> GetAllConfirmendQuestions()
        {
            var collection = mongoDb.LoadRecordByFilter<Question>("Questions", new BsonDocument
            {
                { "AdminAccept", true }
            });
            return collection;
        }

        public void ConfirmQuestion(Question question)
        {
            question.AdminAccept = true;
            mongoDb.UpdateRecord("Questions",question.QuestionId,question);
        }


    }
}
