using EmployeeManagement.Domain;
using EmployeeManagement.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers;
[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _service;

    public EmployeesController(IEmployeeService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetEmployees());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var emp = await _service.GetEmployee(id);
        return emp == null ? NotFound() : Ok(emp);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Employee emp)
    {
        await _service.AddEmployee(emp);
        return Ok(emp);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Employee emp)
    {
        emp.Id = id;
        await _service.UpdateEmployee(emp);
        return Ok(emp);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteEmployee(id);
        return Ok("Deleted successfully");
    }
}
