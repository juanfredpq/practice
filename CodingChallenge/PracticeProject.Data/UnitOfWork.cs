using System.Threading.Tasks;
using PracticeProject.Core;
using PracticeProject.Core.Repositories;
using PracticeProject.Data.Repositories;

namespace PracticeProject.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyProjectDbContext _context;
        private ProjectRepository _projectRepository;
        private UserRepository _userRepository;

        public UnitOfWork(MyProjectDbContext context)
        {
            this._context = context;
        }

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        public IProjectRepository Projects => _projectRepository = _projectRepository ?? new ProjectRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}