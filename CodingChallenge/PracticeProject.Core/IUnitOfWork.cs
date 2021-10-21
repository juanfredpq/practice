using System;
using System.Threading.Tasks;
using PracticeProject.Core.Repositories;

namespace PracticeProject.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        IUserRepository Users { get; }
        Task<int> CommitAsync();
    }
}