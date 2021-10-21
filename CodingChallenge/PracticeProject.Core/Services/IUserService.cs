using System.Collections.Generic;
using System.Threading.Tasks;
using PracticeProject.Core.Models;

namespace PracticeProject.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}