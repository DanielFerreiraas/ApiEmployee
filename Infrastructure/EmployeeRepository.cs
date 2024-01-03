using PrimeiraApi.Model;

namespace PrimeiraApi.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAll(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip(pageNumber * pageQuantity).Take(pageQuantity).ToList();
        }

        public Employee? GetById(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
