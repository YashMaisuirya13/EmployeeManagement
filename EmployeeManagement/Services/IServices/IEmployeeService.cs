using EmployeeManagement.Domain;

namespace EmployeeManagement.Services.IServices;
public interface IEmployeeService
{
    Task<List<Employee>> GetEmployees();
    Task<Employee?> GetEmployee(int id);
    Task AddEmployee(Employee emp);
    Task UpdateEmployee(Employee emp);
    Task DeleteEmployee(int id);

}
