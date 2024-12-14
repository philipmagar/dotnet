using System.Security;

namespace Hamropasal.Models
{
    public class StudentList
    {
        public string Name { get; set; } 
        public string City { get; set; }

        public StudentList( string _name, string _city)
        {
            this.Name = _name;
             this.City = _city;
        }
    }
}
