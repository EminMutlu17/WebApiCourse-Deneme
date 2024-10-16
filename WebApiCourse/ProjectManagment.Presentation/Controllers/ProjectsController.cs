using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
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
            try
            {

                var projects = _serviceManager.ProjectService
                    .GetAllProjects(false);

                return Ok(projects);
            }
            catch (Exception ex)
            {
                return StatusCode(500,"Internal Error");
            }
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetProjectById(Guid id )
        {
            try
            {
                Project project = _serviceManager.ProjectService.GetOneProjectById(id, false);
                return Ok(project);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Error");
            }
        }
    }
}
