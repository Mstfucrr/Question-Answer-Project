using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Question_Answer.Questions
{
    public class Answers
    {
        [BsonId]
        private ObjectId Id { get; set; }

        public ObjectId AnswerId => Id;
        [BsonElement("AnswerText")]
        public string AnswerText { get; set; }
        [BsonElement("TrueOrFalse")]

        public bool TrueOrFalse { get; set; }
        public Answers(bool trueOrFalse, string answerText)
        {
            Id = ObjectId.GenerateNewId();
            this.AnswerText = answerText;
            this.TrueOrFalse = trueOrFalse;
        }
    }
}