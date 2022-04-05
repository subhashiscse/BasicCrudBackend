using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BasicCrudBackend.Model
{
    public class Department
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
