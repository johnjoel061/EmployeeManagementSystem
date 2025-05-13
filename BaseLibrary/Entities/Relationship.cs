using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Relationship
    {
        //Relation : One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
