using Server.Models;

namespace Server.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        Employee GetEmployeeById(int Id);
        List<Employee> GetAllEmployees();
    }
}
