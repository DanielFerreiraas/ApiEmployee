namespace PrimeiraApi.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<Employee> GetAll();

        Employee? GetById(int id);
    }
}
