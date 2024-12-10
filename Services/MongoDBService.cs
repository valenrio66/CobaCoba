using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson.Serialization.Attributes;
using BCrypt.Net;
using System.Diagnostics;

namespace TekananDarahApp.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<User> _users;

        public MongoDBService()
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            var database = client.GetDatabase("healthdb");
            _users = database.GetCollection<User>("users");
        }

        public User RegisterUser(string name, int age, string username, string password)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            Debug.WriteLine($"Registering user: {username}");
            Debug.WriteLine($"Password: {password} -> Hashed: {hashedPassword}");

            var newUser = new User
            {
                UserId = ObjectId.GenerateNewId().ToString(),
                Name = name,
                Age = age,
                Username = username,
                Password = hashedPassword
            };

            _users.InsertOne(newUser);
            return newUser;
        }

        public User LoginUser(string username, string password)
        {
            var user = _users.Find<User>(u => u.Username == username).FirstOrDefault();
            if (user != null)
            {
                Debug.WriteLine($"Attempting to log in user: {username}");
                Debug.WriteLine($"Provided password: {password} -> Stored hash: {user.Password}");
                bool passwordVerified = BCrypt.Net.BCrypt.Verify(password, user.Password);
                Debug.WriteLine($"Password verification result: {passwordVerified}");

                if (passwordVerified)
                {
                    return user;  // Login berhasil
                }
            }
            else
            {
                Debug.WriteLine($"User not found: {username}");
            }
            return null;  // Login gagal
        }

        public void AddDailyHealthRecord(string userId, DateTime date, double weight, string bloodPressure, double bloodSugarLevel)
        {
            var record = new DailyHealthRecord
            {
                UserId = userId,
                Date = date,
                Weight = weight,
                BloodPressure = bloodPressure,
                BloodSugarLevel = bloodSugarLevel
            };

            var database = new MongoClient("mongodb://localhost:27017/").GetDatabase("healthdb");
            var collection = database.GetCollection<DailyHealthRecord>("healthrecord");
            collection.InsertOne(record);
            Debug.WriteLine("Daily health record added for user: " + userId);
        }

        public List<DailyHealthRecord> GetAllHealthRecords()
        {
            var database = new MongoClient("mongodb://localhost:27017/").GetDatabase("healthdb");
            var collection = database.GetCollection<DailyHealthRecord>("healthrecord");
            return collection.Find(_ => true).ToList();
        }

    }

    public class User
    {
        [BsonId] // Menandakan bahwa field ini adalah _id pada MongoDB
        public ObjectId Id { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }

    public class DailyHealthRecord
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("weight")]
        public double Weight { get; set; }

        [BsonElement("bloodPressure")]
        public string BloodPressure { get; set; }

        [BsonElement("bloodSugarLevel")]
        public double BloodSugarLevel { get; set; }
    }

}
