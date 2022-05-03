using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Question_Answer.user.UserClasses;

namespace Question_Answer.user.UserClass
{
    public class User
    {
        [BsonId]
        private ObjectId Id { get; set; }
        public ObjectId UserId => Id;
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Lastname")]
        public string Lastname { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Username")]
        public string Username { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("Role")]
        public string Role { get; set; }
        [BsonElement("Created_Date")]
        public DateTime Created_Date { get; set; }
        [BsonIgnore]
        public Database.MongoDB mongoDB;

        public User()
        {
            Created_Date = DateTime.Now;
            mongoDB = new Database.MongoDB();
        }


        public T GetPassword<T>(string table,string KullaniciAdi, string Eposta)
        {
            return mongoDB.LoadRecordByFilter<T>(table, new BsonDocument
            {
                { "Username", KullaniciAdi },
                { "Email", Eposta }
            }).FirstOrDefault();
        }

        public T Login<T>(string table, string KullaniciAdi, string parola)
        {
            return mongoDB.LoadRecordByFilter<T>(table, new BsonDocument
            {
                { "Username", KullaniciAdi },
                { "Password", parola }
            }).FirstOrDefault();
        }

        public void Save(string table)
        {
            mongoDB.InsertRecord(table, this);
        }

        public void Update(string table)
        {
            mongoDB.UpdateRecord(table, this.UserId, this);
        }

        public bool UsersUsernameAndEmailCheck(string kullaniciadi)
        {
            if (mongoDB.LoadRecords<Student>("Students")
                .Any(kullanici => kullanici.Username == kullaniciadi))
            {
                return false;
            }

            return mongoDB.LoadRecords<Teacher>("Teachers")
                .All(kullanici => kullanici.Username != kullaniciadi);
        }

    }


}
