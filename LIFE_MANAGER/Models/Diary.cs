using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFE_MANAGER.Models
{
    public class Diary
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("Date")]
        public string Date { get; set; }
        [BsonElement("DateSplit")]
        public List<string> DateSplit { get; set; }
        [BsonElement("DiaryNote")]
        public string DiaryNote { get; set; }
        [BsonElement("Images")]
        public List<string> Images { get; set; }
        [BsonElement("Drawing")]
        public string DrawingImage { get; set; }
        [BsonElement("Mood")]
        public string Mood { get; set; }
        [BsonElement("UserId")]
        public ObjectId UserId { get; set; }
    }
}
