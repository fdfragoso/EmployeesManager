using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; private set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Photo { get; set; }

        public Employee(string _name, int _age, string _photo)
        {
            this.Name = _name ?? throw new ArgumentNullException(nameof(Name));
            this.Age = _age;
            this.Photo = _photo;
        }
    }
}
