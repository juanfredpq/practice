using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Models;
using PracticeProject.Core.Repositories;

namespace PracticeProject.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MyProjectDbContext context) 
            : base(context)
        { }
        public async Task<IEnumerable<User>> GetAllWithProjectsAsync()
        {
            return await MyProjectDbContext.Users
                .Include(a => a.Projects)
                .ToListAsync();
        }

        public Task<User> GetWithProjectsByIdAsync(int id)
        {
            return MyProjectDbContext.Users
                .Include(a => a.Projects)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        private MyProjectDbContext MyProjectDbContext
        {
            get { return Context as MyProjectDbContext; }
        }
    }
}