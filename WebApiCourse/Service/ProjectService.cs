using Contracts;
using Entities.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProjectService : IProjectService
    {


        private readonly IRepositoryManager _repositoryManager ; 

        private readonly ILoggerManager _loggerManager ;

        public ProjectService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Project> GetAllProjects(bool trachChanges)
        {
           var projects = _repositoryManager.Project.GetAllProjects(trachChanges); 
            return projects;
        }

        public Project GetOneProjectById(Guid id, bool trackChanges)
        {
            try
            {
               return  _repositoryManager.Project.GetOneProjectById(id, trackChanges);

                
                
            }
            catch(Exception ex) 
            {
                _loggerManager.LogError("ProjectRepository.GetProject() : " + ex.Message);
                throw;
            }
        }
    }

}
