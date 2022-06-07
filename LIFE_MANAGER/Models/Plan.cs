using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFE_MANAGER.Models
{
    public class Plan
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("Data")]
        public string Data { get; set; }
        [BsonElement("UserId")]
        public ObjectId UserId { get; set; }

    }
}
