using Microsoft.AspNetCore.Mvc;
using Server.Model;
using Server.Models;
using Server.ViewModel;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel _employeeViewModel)
        {
            var employee = new Employee(_employeeViewModel.Name, _employeeViewModel.Age, null);
            _employeeRepository.Add(employee);
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Employee> DeleteEmployeeById(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            if (employee != null)
            {
                _employeeRepository.Delete(employee);
                return Ok();
            }
            else
            {
                return NotFound($"Employee with id: {id} does not exist!");
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employee = _employeeRepository.GetAllEmployees();

            return Ok(employee);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetBookById(int id)
        {
            //Book book = books.FirstOrDefault(b => b.Id == id);
            Employee employee = _employeeRepository.GetEmployeeById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound($"Employee with id {id} does not exist!");
            }
        }


    }
}
