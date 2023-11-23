using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace gluschKt_42_20.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int GroupId { get; set; }
        [JsonIgnore]
        public Group? Group { get; set; }
    }
}
