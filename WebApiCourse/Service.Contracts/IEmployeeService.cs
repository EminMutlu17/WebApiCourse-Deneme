using Entities.Models;
using Shareds.DTO;

namespace Service.Contracts
{
    public interface IEmployeeService
    {
        EmployeeDto CreateOneEmployeeByProjectId(Guid projectId, EmployeeDtoForCreation employeeDtoForCreation, bool trackChanges);


        IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid id , bool trackChanges);
        EmployeeDto GetOneEmployeeByProjectId(Guid id,Guid employeeId , bool trackChanges);


        

    }
}
