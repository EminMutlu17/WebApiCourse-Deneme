using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagment.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private List<Project> _projectList;
        
        private ILoggerManager _logger;

        public ProjectsController(ILoggerManager logger)
        {
            _logger = logger;
            _projectList = new List<Project>
            {
                new Project {ID = Guid.NewGuid(), Name ="Project 1"},
                new Project {ID = Guid.NewGuid(), Name ="Project 2"},
                new Project {ID = Guid.NewGuid(), Name ="Project 3"},


            };
        }



        [HttpGet]
        public IActionResult Get()
        {
            try {
                _logger.LogInfo("project.Get() has been run .");
                return Ok(_projectList);
            }
            catch (Exception ex)
            {
                _logger.LogError("project.Get() has been CRASHED !" + ex.Message);
                throw;

            }
            }


    }

}