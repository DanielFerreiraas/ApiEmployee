using PrimeiraApi.Domain.DTOs;
using PrimeiraApi.Domain.Model;

namespace PrimeiraApi.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<EmployeeDTO> GetAll(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(b =>
                new EmployeeDTO()
                {
                    Id = b.id,
                    NameEmployee = b.name,
                    photo = b.photo
                }).ToList();
        }

        public Employee? GetById(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
