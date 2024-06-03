using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeAPI.Data;
using EMPApis.Models;
using EMPApis.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace EMPApis.Repositories
{
    public class EmployeeRepository : IGetEmployee
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<EmployeeModel>> GetEmployeesAsync()
        {
            try
            {
                return await _context.Employee.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new ApplicationException("Error retrieving employee data", ex);
            }
        }
        public async Task<EmployeeModel> CreateEmployeeAsync(EmployeeModel empData)
        {
            try
            {
                _context.Employee.Add(empData);
                await _context.SaveChangesAsync();  
                return empData;
            }catch(Exception ex)
            {
                throw new Exception("Error creating employee", ex);

            }
        }
        public async Task<EmployeeModel> UpdateEmployeeAsync(EmployeeModel employee)
        {
          var existingEmployee = await _context.Employee.FindAsync(employee.ID);
            if (existingEmployee == null) {

                throw new ArgumentException($"Employee with ID {employee.ID} not found");
            }

            try{
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.MiddleName = employee.MiddleName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Address1 = employee.Address1;
                existingEmployee.Address2 = employee.Address2;
                existingEmployee.City = employee.City;
                existingEmployee.State = employee.State;
                existingEmployee.Zip = employee.Zip;
                existingEmployee.JoiningDate = employee.JoiningDate;
                existingEmployee.Department = employee.Department;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.HasLeft = employee.HasLeft;
                existingEmployee.LeavingDate = employee.LeavingDate;
                existingEmployee.CreatedDate = employee.CreatedDate;
                existingEmployee.CreatedBy = employee.CreatedBy;
                existingEmployee.UpdatedOn = DateTime.Now;
                _context.Employee.Update(existingEmployee);
                await _context.SaveChangesAsync();
                return existingEmployee;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating employee", ex);
            }
        }
        public async Task DeleteEmployeeAsync(int Id)
        {
            try
            {
                var isEmployeeExists = await _context.Employee.FindAsync(Id);
                if (isEmployeeExists == null)
                {
                    throw new Exception($"Employee for Id {Id} does not found.");
                }
                else
                {
                    _context.Employee.Remove(isEmployeeExists);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex) {
                throw new Exception($"Employee dose not exists for Id{Id} and {ex.Message}");
            }
        }
    }
}
