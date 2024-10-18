using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shareds.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectManagment.Presentation.Controllers
{

    [ApiController]
    [Route("api/projects/{projectId}/employees")]
    public class EmployeesController : ControllerBase
    {

        private readonly IServiceManager _servicemanager;

        public EmployeesController(IServiceManager servicemanager)
        {
            _servicemanager = servicemanager;
        }

        [HttpGet]
        public IActionResult GetAllEmployeeByProjectId(Guid  projectId)
        {
           
            
                var employeeList = _servicemanager.EmployeeService.GetAllEmployeesByProjectId(projectId, false);
                return Ok(employeeList);
           
        }

        [HttpGet ("{id:guid}" , Name ="GetOneEmployeeByProjectIdAndId")]

        public IActionResult GetOneEmployeeByProjectId(Guid projectId , Guid id) {
           
                var employee =  _servicemanager.EmployeeService.GetOneEmployeeByProjectId(projectId , id , false);
                return Ok(employee);

            
        }

        [HttpPost]
        public IActionResult CreateOneEmployeeByProjectId(Guid projectId , EmployeeDtoForCreation employeeDtoForCreation) 
        {

            EmployeeDto employee = _servicemanager.EmployeeService.CreateOneEmployeeByProjectId(projectId, employeeDtoForCreation, true);
            

            return CreatedAtRoute("GetOneEmployeeByProjectIdAndId",
                new {projectId , id = employee.Id},
                employee);



        }
  
    }
}
