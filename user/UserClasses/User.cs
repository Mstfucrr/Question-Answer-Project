using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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

        public Database.MongoDB mongoDB;

        public User()
        {
            Created_Date = DateTime.Now;
            mongoDB = new Database.MongoDB();
        }

        public User Login(string KullaniciAdi,string Parola)
        {
            return mongoDB.LoadRecordByFilter<User>("User",new BsonDocument
            {
                { "Username", KullaniciAdi },
                { "Password", Parola }
            }).FirstOrDefault();
        }

        public List<T> GetRole<T>(string role)
        {
            return mongoDB.LoadRecordByFilter<T>("User", new BsonDocument
            {
                { "Role", role }
            });
        }

        public User GetPassword<T>(string KullaniciAdi, string Eposta)
        {
            return mongoDB.LoadRecordByFilter<User>("User", new BsonDocument
            {
                { "Username", KullaniciAdi },
                { "Email", Eposta }
            }).FirstOrDefault();
        }

    }


}
