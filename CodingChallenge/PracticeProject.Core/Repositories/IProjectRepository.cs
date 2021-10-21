using System.Collections.Generic;
using System.Threading.Tasks;
using PracticeProject.Core.Models;

namespace PracticeProject.Core.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<IEnumerable<Project>> GetAllWithUserAsync();
        Task<Project> GetWithUserByIdAsync(int id);
        Task<IEnumerable<Project>> GetAllWithUserByUserIdAsync(int userId);
    }
}