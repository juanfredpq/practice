using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Models;
using PracticeProject.Core.Repositories;

namespace PracticeProject.Data.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(MyProjectDbContext context) 
            : base(context)
        { }

        public async Task<IEnumerable<Project>> GetAllWithUserAsync()
        {
            return await MyProjectDbContext.Projects
                .Include(m => m.User)
                .ToListAsync();
        }

        public async Task<Project> GetWithUserByIdAsync(int id)
        {
            return await MyProjectDbContext.Projects
                .Include(m => m.User)
                .SingleOrDefaultAsync(m => m.Id == id);;
        }

        public async Task<IEnumerable<Project>> GetAllWithUserByUserIdAsync(int userId)
        {
            return await MyProjectDbContext.Projects
                .Include(m => m.User)
                .Where(m => m.Id == userId)
                .ToListAsync();
        }
        
        private MyProjectDbContext MyProjectDbContext
        {
            get { return Context as MyProjectDbContext; }
        }
    }
}