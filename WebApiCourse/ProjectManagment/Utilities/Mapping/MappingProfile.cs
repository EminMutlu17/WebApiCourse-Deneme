using AutoMapper;
using Entities.Models;
using Shareds.DTO;

namespace ProjectManagment.Utilities.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<ProjectDtoForCreation, Project>();


            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeDtoForCreation, Employee>();







        }
    }
}
