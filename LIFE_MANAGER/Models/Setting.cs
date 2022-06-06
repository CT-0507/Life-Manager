using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFE_MANAGER.Models
{
    public class Setting
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("Notification")]
        public bool isNotification { get; set; }
        [BsonElement("BackgroundMusicVolume")]
        public bool isBackgroundMusicVolume { get; set; }
        [BsonElement("StartWithWindows")]
        public bool StartWithWindows { get; set; }
        [BsonElement("BackgroundImage")]
        public string BackgroundImage { get; set; }
        [BsonElement("UserId")]
        public ObjectId UserId { get; set; }
    }
}
