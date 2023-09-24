using Hangfire.Application.Domain;

namespace Hangfire.Application.Interfaces.Repository
{
    public interface IQuartoJobRepository : IRepository<QuartoJob>
    {
        Task<IEnumerable<QuartoJob>> GetAll();
    }
}
