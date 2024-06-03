using System.Collections.Generic;
using System.Threading.Tasks;
using EMPApis.Models;

namespace EMPApis.Repositories
{
    public interface IGetEmployee
    {
        Task<IEnumerable<EmployeeModel>> GetEmployeesAsync();
        Task<EmployeeModel> CreateEmployeeAsync(EmployeeModel EMPData);
        Task<EmployeeModel> UpdateEmployeeAsync(EmployeeModel EMPData);
        Task DeleteEmployeeAsync(int id);
    }
}
