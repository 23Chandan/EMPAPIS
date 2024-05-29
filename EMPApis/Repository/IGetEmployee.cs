using System.Collections.Generic;
using System.Threading.Tasks;
using EMPApis.Models;

namespace EMPApis.Repositories
{
    public interface IGetEmployee
    {
        Task<IEnumerable<EmployeeModel>> GetEmployeesAsync();
    }
}
