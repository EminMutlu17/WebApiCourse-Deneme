using Contracts;
using Entities.Models;
using Service.Contracts;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {

        private IRepositoryManager _repositoryManager ;
        private ILoggerManager _loggerManager ;

        public EmployeeService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Employee> GetAllEmployeesByProjectId(Guid projectID, bool trackChanges)
        {
            try
            {
                var employeeList = _repositoryManager.Employee.GetEmployeesByProjectId(projectID, trackChanges);
                return employeeList;
            }
            catch(Exception ex)
            {
                _loggerManager.LogError("EmployeeService.GetAllEmployeeByProjectId : " + ex.Message);
                throw;
            }
        }

        public Employee GetOneEmployeeByProjectId(Guid projectId,Guid employeeId,bool trackChanges)
        {
            try
            {
                var employee = _repositoryManager.Employee.GetEmployeeByProjectId(projectId, employeeId, trackChanges);    
                return employee;
            }
            catch(Exception ex) 
            {
                _loggerManager.LogError("EmployeeService.GetOneEmployeeByProjectId : " + ex.Message);
                throw; 
            }
        }
    }

}
