using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Question_Answer.Questions.QuestionClasses
{
    public class QuestionDaySetting
    {
        [BsonId]
        private ObjectId Id { get; set; }
        public ObjectId QuestionDaySettingId => Id;
        [BsonElement("Question_Days")]
        private List<int> Question_Days { get; set; }

        private Database.MongoDB mongoDB;

        public QuestionDaySetting()
        {
            mongoDB = new Database.MongoDB();
        }
        public List<int> GetQuestionDays()
        {
            var questionDay = mongoDB.LoadRecords<QuestionDaySetting>("QuestionDaySettings").First();
            this.Id = questionDay.Id;
            return questionDay.Question_Days;
        }

        public void SetQuestionDays(List<int> days)
        {
            Question_Days = days;
            mongoDB.UpdateRecord("QuestionDaySettings", QuestionDaySettingId, this);
        }

    }
}
