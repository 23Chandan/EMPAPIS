using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeAPI.Data;
using EMPApis.Models;
using EMPApis.Repositories;

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
    }
}
