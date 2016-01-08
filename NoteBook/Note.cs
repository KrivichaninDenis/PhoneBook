using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace NoteBook
{
    [BsonIgnoreExtraElements]
    public class Note
    {
        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Patronymic")]
        public string Patronymic { get; set; }

        [BsonElement("ListNumb")]
        public List<Number> ListNumb = new List<Number>();

         [BsonElement("NoteDescription")]
        public string NoteDescription { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + " " + Patronymic;
        }

        
    }
}
