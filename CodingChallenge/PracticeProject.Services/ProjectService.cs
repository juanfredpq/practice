using System.Collections.Generic;
using System.Threading.Tasks;
using PracticeProject.Core;
using PracticeProject.Core.Models;
using PracticeProject.Core.Services;

namespace PracticeProject.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProjectService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
       
        public async Task<IEnumerable<Project>> GetAllWithUser()
        {
            return await _unitOfWork.Projects
                .GetAllWithUserAsync();
        }

        public async Task<Project> GetProjectById(int id)
        {
            return await _unitOfWork.Projects
                .GetWithUserByIdAsync(id);
        }

        public async Task<IEnumerable<Project>> GetProjectsByUserId(int userId)
        {
            return await _unitOfWork.Projects
                .GetAllWithUserByUserIdAsync(userId);
        }

      
    }
}