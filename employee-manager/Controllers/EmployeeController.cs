using employee_manager.Models;
using employee_manager.Utils;
using Microsoft.AspNetCore.Mvc;

namespace employee_manager.Controllers;

[Route("employees")]
public class EmployeeController : ControllerBase {
    
    private static readonly List<Employee> Employees = EmployeesList.Employees;

    [HttpGet]
    public IActionResult FindAll() {
        return Ok(Employees);
    }

    [HttpGet("{id}")]
    public IActionResult FindById(int id) {
        var employee = (
            from e in Employees
            where e.Id == id
            select e
        ).FirstOrDefault();
        
        if (employee == null) return NotFound($"Employee not found with ID: {id}");
        
        return Ok(employee);
    }

    [HttpGet("getAllByGender")]
    public IActionResult GetAllByGender([FromQuery(Name = "gender")]string genderStr) {
        if (string.IsNullOrEmpty(genderStr) || (!genderStr.Equals("Male") && !genderStr.Equals("Female")))
            return BadRequest("Invalid query value");
        
        Gender gender;
        Enum.TryParse(genderStr, true, out gender);
        
        return Ok(
            from e in Employees
            where e.Gender == gender 
            select e
        );
    }
    
    [HttpGet("getAllByNationality")]
    public IActionResult GetAllByNationality([FromQuery(Name = "nationality")]string nationality) {
        if (string.IsNullOrEmpty(nationality)) return BadRequest("Invalid query value");
        
        return Ok(
            from e in Employees
            where e.Nationality.Equals(nationality) 
            select e
        );
    }
    
}