using PrimeiraApi.Domain.DTOs;

namespace PrimeiraApi.Domain.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<EmployeeDTO> GetAll(int pageNumber, int pageQuantity);

        Employee? GetById(int id);
    }
}
