using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shareds.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProjectService : IProjectService
    {


        private readonly IRepositoryManager _repositoryManager ; 

        private readonly ILoggerManager _loggerManager ;

        private readonly IMapper _mapper ;

        public ProjectService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

      
        public IEnumerable<ProjectDto> GetAllProjects(bool trachChanges)
        {
           var projects = _repositoryManager.Project.GetAllProjects(trachChanges);

            // Entity -> Dto 

            var projectDtos = _mapper.Map<IEnumerable<ProjectDto>>(projects);
           return projectDtos;
        }

        public ProjectDto GetOneProjectById(Guid id, bool trackChanges)
        {
           
                
               var project =  _repositoryManager.Project.GetOneProjectById(id, trackChanges);

                
                 if (project == null)
                {
                throw new ProjectNotFoundException(id);

                }

               
              // Entity -> Dto 

               var projectDto = _mapper.Map<ProjectDto>(project);
               return projectDto; 

               
                
      
        }

        public ProjectDto CreateOneProject(ProjectDtoForCreation projectDtoForCreation)
        {
          // Dto -> Entity 

            var entity = _mapper.Map<Project>(projectDtoForCreation);


          // Repo -> Save 

            _repositoryManager.Project.CreateProject(entity);
            _repositoryManager.Save();

          // Entity -> Dto

            return _mapper.Map<ProjectDto>(entity);
        }

    }

}
