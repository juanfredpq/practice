using AutoMapper;
using PracticeProject.Api.Resources;
using PracticeProject.Core.Models;

namespace PracticeProject.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Project, ProjectResource>();
            CreateMap<User, UserResource>();
            
            // Resource to Domain
            CreateMap<ProjectResource, Project>();
            CreateMap<SaveProjectResource, Project>();
            CreateMap<UserResource, User>();
            CreateMap<SaveUserResource, User>();
        }
    }
}