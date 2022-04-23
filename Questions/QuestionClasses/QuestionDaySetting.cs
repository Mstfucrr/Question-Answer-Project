using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Question_Answer.Questions.QuestionClasses
{
    public class QuestionDaySetting
    {
        [BsonId]
        private ObjectId Id { get; set; }
        public ObjectId QuestionDaySettingId => Id;
        public ObjectId StudentId { get; set; }
        [BsonElement("Question_Days")]
        private List<int> Question_Days { get; set; }

        private Database.MongoDB mongoDB;

        public QuestionDaySetting()
        {
            mongoDB = new Database.MongoDB();
        }
        public List<int> GetQuestionDays(ObjectId StudentId)
        {
            this.StudentId = StudentId;
            try
            {
                var questionDay = mongoDB.LoadRecordByFilter<QuestionDaySetting>("QuestionDaySettings", new BsonDocument()
                {
                    {"StudentId", this.StudentId}
                }).First();
                this.Id = questionDay.Id;
                return questionDay.Question_Days;
            }
            catch (Exception)
            {
                // defoult question days
                var days = new List<int>
                {
                    1,
                    8,
                    30,
                    180,
                    365
                };
                this.Question_Days = days;
            }
            return Question_Days;

        }

        public void SetQuestionDays(List<int> days, ObjectId StudentId)
        {
            this.StudentId = StudentId;
            Question_Days = days;
            try
            {
                var StudentSetting = mongoDB.LoadRecordByFilter<QuestionDaySetting>("QuestionDaySettings",
                    new BsonDocument()
                    {
                        {"StudentId", StudentId}
                    }).First();
                mongoDB.UpdateRecord("QuestionDaySettings", QuestionDaySettingId, this);
            }
            catch (Exception)
            {
                mongoDB.InsertRecord("QuestionDaySettings", this);
            } ;
            
        }
    }
}
