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

        public Employee(string name, int age, string photo)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(Name));
            this.Age = age;
            this.Photo = photo;
        }
    }
}
