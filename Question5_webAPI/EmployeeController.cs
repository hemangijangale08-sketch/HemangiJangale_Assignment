// Simple Web API with GET and POST
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new List<Employee>();

    [HttpGet]
    public IActionResult GetEmployees()
    {
        return Ok(employees);
    }

    [HttpPost]
    public IActionResult AddEmployee(Employee emp)
    {
        employees.Add(emp);
        return Ok("Employee Added Successfully");
    }
}
