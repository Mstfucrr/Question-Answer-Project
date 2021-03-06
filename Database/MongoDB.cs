using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Question_Answer.Questions;

namespace Question_Answer.Database
{
    public class MongoDB
    {
        private IMongoDatabase db;

        public MongoDB()
        {
            var client = new MongoClient("mongodb+srv://mstfucrr:123321@question-answer-cluster.hly97.mongodb.net/myFirstDatabase?retryWrites=true&w=majority"); //db con
            db = client.GetDatabase("Question-Answer-Database");
        }
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public IMongoQueryable<Question> RandomQuestionsWithFilter()
        {
            var collection = db.GetCollection<Question>("Questions");
            var coll = collection.AsQueryable()
                .Where(q => q.AdminAccept)
                .Sample(10);
            return coll;
        }

        public T LoadRecordById<T>(string table, ObjectId Id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", Id);
            return collection.Find(filter).First();
        }

        public List<T> LoadRecordByFilter<T>(string table, BsonDocument document)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(document).ToList();
        }

        public void UpdateRecord<T>(string table, ObjectId Id, T record)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", Id);
            collection.ReplaceOne(filter, record, new UpdateOptions { IsUpsert = true });
        }
    }
}
