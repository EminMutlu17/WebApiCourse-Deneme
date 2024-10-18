using Entities.ErrorModels;
using Entities.Models;
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
    [Route("api/projects")]

    public  class ProjectsController : ControllerBase
    {


        private readonly IServiceManager _serviceManager;

        public ProjectsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }





        [HttpGet]
        public IActionResult GetAllProjects() 
        {
            

                var projects = _serviceManager.ProjectService
                    .GetAllProjects(false);

                return Ok(projects);
           
        }

        [HttpGet("{id:guid}", Name ="ProjectById")]
        public IActionResult GetProjectById(Guid id )
        {

            
                var project = _serviceManager.ProjectService.GetOneProjectById(id, false);
                return Ok(project);
            
        }


        [HttpPost]  // 201  : Created
        public IActionResult CreateOneProject([FromBody] ProjectDtoForCreation projectDtoForCreation)
        {

            var project = _serviceManager.ProjectService.CreateOneProject(projectDtoForCreation);

            return CreatedAtRoute("ProjectById", new { id = project.Id }, project);

        }
    }
}
