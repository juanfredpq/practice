using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PracticeProject.Api.Resources;
using PracticeProject.Api.Validations;
using PracticeProject.Core.Models;
using PracticeProject.Core.Services;

namespace PracticeProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;
        
        public ProjectController(IProjectService projectService, IMapper mapper)
        {
            this._mapper = mapper;
            this._projectService = projectService; 
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ProjectResource>>> GetAllProjects()
        {
            var projects = await _projectService.GetAllWithUser();
            var projectResources = _mapper.Map<IEnumerable<Project>, IEnumerable<ProjectResource>>(projects);

            return Ok(projectResources);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectResource>> GetProjectById(int id)
        {
            var project = await _projectService.GetProjectById(id);
            var projectResource = _mapper.Map<Project, ProjectResource>(project);

            return Ok(projectResource);
        }             
    }
}