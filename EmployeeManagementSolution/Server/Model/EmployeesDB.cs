using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Model
{
    public class EmployeesDB : DbContext
    {
        public EmployeesDB(DbContextOptions<EmployeesDB> options) : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
