using Server.Models;

namespace Server.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<Employee> GetAllEmployees();


        /*Book GetBookById(int id);
        Book CreateBook(Book newBook); // Post
        Book UpdateBook(Book updatedBook); // Put or Patch
        void DeleteBook(Book poorBook); // Delete*/
    }
}
