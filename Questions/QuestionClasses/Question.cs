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

        [BsonElement("AdderTeacherId")]
        public ObjectId AdderTeacherId; 
        
        [BsonElement("QuestionUnit")]
        public string QuestionUnit { get; set; }

        [BsonElement("QuestionSubject")]
        public string QuestionSubject { get; set; }

        [BsonElement("QuestionTime")]
        public int QuestionTime { get; set; }

        [BsonIgnore]
        private Database.MongoDB mongoDB;
        [BsonIgnore]
        public static string GetDirectoryName = Path.GetDirectoryName(Application.ExecutablePath);
        [BsonIgnore]
        public string QuestionImagesUploadLocation = GetDirectoryName.Remove(GetDirectoryName.Length - (@"\bin\Debug").Length) + @"\Images\QuestionImagesUpload";


        public Question()
        {
            Answers = new List<Answers>();
            mongoDB = new Database.MongoDB();
        }

        public void Save()
        {
            mongoDB.InsertRecord("Questions",this);
        }

        public List<Question> Rastgele10SoruGetir()
        {
            var questions = mongoDB.LoadRecordRandomQuestion();
            return questions.ToList();
        }

    }
}
