using Server.Models;

namespace Server.Model
{
    public class EmployeesRepository : IEmployeeRepository
    {
        private readonly EmployeesDB _db;

        public void Add(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _db.Employees.ToList();
        }
    }
}
