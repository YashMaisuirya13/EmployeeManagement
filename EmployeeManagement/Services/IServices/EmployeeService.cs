using EmployeeManagement.Domain;
using EmployeeManagement.Repositories.IRepositories;

namespace EmployeeManagement.Services.IServices;
public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repo;
    public EmployeeService(IEmployeeRepository repo)
    {
        _repo = repo;
    }
    public Task<List<Employee>> GetEmployees()
      => _repo.GetAllAsync();

    public Task<Employee?> GetEmployee(int id)
        => _repo.GetByIdAsync(id);

    public async Task AddEmployee(Employee emp)
    {
        if (string.IsNullOrWhiteSpace(emp.Name))
            throw new Exception("Name is required");

        if (emp.Salary <= 0)
            throw new Exception("Salary must be greater than 0");

        await _repo.AddAsync(emp);
    }

    public async Task UpdateEmployee(Employee emp)
    {
        await _repo.UpdateAsync(emp);
    }

    public async Task DeleteEmployee(int id)
    {
        var emp = await _repo.GetByIdAsync(id);
        if (emp == null) throw new Exception("Employee not found");

        await _repo.DeleteAsync(emp);
    }

}
