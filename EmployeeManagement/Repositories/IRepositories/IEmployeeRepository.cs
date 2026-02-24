using EmployeeManagement.Domain;

namespace EmployeeManagement.Repositories.IRepositories;
public interface IEmployeeRepository
{
    Task<List<Employee>> GetAllAsync();
    Task<Employee?> GetByIdAsync(int id);
    Task AddAsync(Employee emp);
    Task UpdateAsync(Employee emp);
    Task DeleteAsync(Employee emp);
}
