using System.Collections.Generic;
using System.Threading.Tasks;
using PracticeProject.Core;
using PracticeProject.Core.Models;
using PracticeProject.Core.Services;

namespace PracticeProject.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
       
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }
        
    }
}
