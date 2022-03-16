using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Question_Answer.Questions
{
    public class Question
    {
        [BsonId]
        private ObjectId Id { get; set; }
        public ObjectId QuestionId => Id;
        [BsonElement("QuestionText")]
        public string QuestionText { get; set; }
        [BsonElement("QuestionImage")]
        public string QuestionImage { get; set; }
        [BsonElement("Answers")]
        public List<Answers> Answers;

        [BsonElement("AdminAccept")]
        public bool AdminAccept { get; set; }
        
        [BsonElement("Unit")]
        public int Unit { get; set; }

        [BsonElement("Subject")]
        public string Subject { get; set; }


        private Database.MongoDB mongoDB;

        public static string GetDirectoryName = Path.GetDirectoryName(Application.ExecutablePath);
        public string QuestionImagesUploadLocation = GetDirectoryName.Remove(GetDirectoryName.Length - (@"\bin\Debug").Length) + @"\Images\QuestionImagesUpload";


        public Question()
        {
            Answers = new List<Answers>();
            mongoDB = new Database.MongoDB();
        }


        public List<Question> Rastgele10SoruGetir<T>()
        {
            var questions = mongoDB.LoadRecordRandomQuestion<Question>(10);
            return questions.ToList();
        }
    }
}
