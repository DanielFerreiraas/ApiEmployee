using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Model;

namespace PrimeiraApi.Infrastructure
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=employee_sample;User Id=postgres;password=123456;");
    }
}
