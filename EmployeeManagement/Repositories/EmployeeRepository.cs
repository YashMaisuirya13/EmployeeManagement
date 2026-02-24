using EmployeeManagement.Data;
using EmployeeManagement.Domain;
using EmployeeManagement.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories;
public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext _dbContext;
    public EmployeeRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Employee>> GetAllAsync()
       => await _dbContext.Employees.ToListAsync();

    public async Task<Employee?> GetByIdAsync(int id)
        => await _dbContext.Employees.FindAsync(id);

    public async Task AddAsync(Employee emp)
    {
        try
        {
            _dbContext.Employees.Add(emp);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task UpdateAsync(Employee emp)
    {
        _dbContext.Employees.Update(emp);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Employee emp)
    {
        _dbContext.Employees.Remove(emp);
        await _dbContext.SaveChangesAsync();
    }
}
