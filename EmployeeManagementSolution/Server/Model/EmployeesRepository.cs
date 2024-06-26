using Server.Models;

namespace Server.Model
{
    public class EmployeesRepository : IEmployeeRepository
    {
        private readonly EmployeesDB _db;

        public EmployeesRepository(EmployeesDB db)
        {
            _db = db;
        }

        public void Add(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }

        public void Update(Employee employee)
        {
            Employee employeeInDb = _db.Employees.Find(employee.Id);

            if (employeeInDb != null)
            {
                employeeInDb.Name = employee.Name;
                employeeInDb.Age = employee.Age;
                _db.Employees.Update(employeeInDb);
                _db.SaveChanges();
            }
        }

        public Employee GetEmployeeById(int id)
        {
            return _db.Employees.Find(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _db.Employees.ToList();
        }
    }
}
