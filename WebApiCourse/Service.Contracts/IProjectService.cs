using Entities.Models;
using Shareds.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public  interface IProjectService

    {
        ProjectDto CreateOneProject(ProjectDtoForCreation projectDtoForCreation);
        IEnumerable<ProjectDto> GetAllProjects(bool trackChanges);
        ProjectDto GetOneProjectById(Guid id, bool trackChanges);
    }
}
