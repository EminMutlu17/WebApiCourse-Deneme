using Entities.Models;

namespace Service.Contracts
{
    public interface IEmployeeService
    {

        IEnumerable<Employee> GetAllEmployeesByProjectId(Guid id , bool trackChanges);
        Employee GetOneEmployeeByProjectId(Guid id,Guid employeeId , bool trackChanges);

        

    }
}
