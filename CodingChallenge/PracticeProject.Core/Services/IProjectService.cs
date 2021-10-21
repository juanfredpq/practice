using System.Collections.Generic;
using System.Threading.Tasks;
using PracticeProject.Core.Models;

namespace PracticeProject.Core.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllWithUser();
        Task<Project> GetProjectById(int id);
        Task<IEnumerable<Project>> GetProjectsByUserId(int userId);
       
    }
}