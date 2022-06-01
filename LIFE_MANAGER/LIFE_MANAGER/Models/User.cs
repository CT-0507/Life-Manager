using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace LIFE_MANAGER.Models
{
    internal class User
    {
        [BsonId]

        public ObjectId _id { get; set; }
        //[Required(ErrorMessage = "Email Required")]
        [BsonElement("Username")]
        public string Username { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        public override string ToString()
        {
            if (this != null && this.Username != null && this.Password != null)
                return "Person: " + Username + " " + Password;
            return "No user found";
        }
        public void hashPassword()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(this.Password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            this.Password = savedPasswordHash;
        }
        
    }
}
