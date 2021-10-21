using System.Collections.Generic;
using System.Threading.Tasks;
using PracticeProject.Core.Models;

namespace PracticeProject.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAllWithProjectsAsync();
        Task<User> GetWithProjectsByIdAsync(int id);
    }
}