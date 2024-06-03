using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using EMPApis.Models;
using EMPApis.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace EMPApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGetEmployee _employeeRepository;

        public ValuesController(IGetEmployee employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                IEnumerable<EmployeeModel> employees = await _employeeRepository.GetEmployeesAsync();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeModel employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null");
            }

            try
            {
                EmployeeModel createdEmployee = await _employeeRepository.CreateEmployeeAsync(employee);
                return CreatedAtAction(nameof(Get), new { id = createdEmployee.ID }, createdEmployee); // Assuming your EmployeeModel has an Id property
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(EmployeeModel employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null");
            }
            try
            {
                EmployeeModel empupdated = await _employeeRepository.UpdateEmployeeAsync(employee);
                return Ok(empupdated);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during update {ex.Message}");
            }
        }
        [HttpDelete]
        public async Task Delet(int ID)
        {
            if(ID == null)
            {
                 BadRequest("ID is null");
            }
            else
            {
                await _employeeRepository.DeleteEmployeeAsync(ID);
            }
        }
    }
}
