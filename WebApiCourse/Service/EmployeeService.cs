using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shareds.DTO;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {

        private IRepositoryManager _repositoryManager ;
        private ILoggerManager _loggerManager ;
        private IMapper _mapper ;

        public EmployeeService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

      

        public IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges)
        {



            ChecckProjectExist(projectId);


            var employeeList = _repositoryManager.Employee.GetEmployeesByProjectId(projectId, trackChanges);
            var employeeDtos = _mapper.Map<IEnumerable<EmployeeDto>>(employeeList);
            return employeeDtos;
            }
       

        public EmployeeDto GetOneEmployeeByProjectId(Guid projectId,Guid employeeId,bool trackChanges)
        {
            ChecckProjectExist(projectId);

            var employee = _repositoryManager.Employee.GetEmployeeByProjectId(projectId, employeeId, trackChanges);

            if (employee == null)
            {
                throw new EmployeeNotFoundException(employeeId);
            }



            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return employeeDto;


        }

        private void ChecckProjectExist(Guid projectId)
        {
            var project = _repositoryManager.Project.GetOneProjectById(projectId, false);
            if (project == null)
            {
                throw new ProjectNotFoundException(projectId);
            }
        }

        public EmployeeDto CreateOneEmployeeByProjectId(Guid projectId, EmployeeDtoForCreation employeeDtoForCreation, bool trackChanges)
        {



            ChecckProjectExist(projectId);

            // Dto -> Entity

            var entity = _mapper.Map<Employee>(employeeDtoForCreation);
            entity.ProjectId = projectId;

            // Repo -> Save 

            _repositoryManager.Employee.CreateEmployeeForProject(projectId, entity);
            _repositoryManager.Save();

            // Entity -> Dto

            return _mapper.Map<EmployeeDto>(entity);




           


        }
    }

}
