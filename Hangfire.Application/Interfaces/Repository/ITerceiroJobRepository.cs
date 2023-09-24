using Hangfire.Application.Domain;

namespace Hangfire.Application.Interfaces.Repository
{
    public interface ITerceiroJobRepository : IRepository<TerceiroJob>
    {
        Task<IEnumerable<TerceiroJob>> GetAll();
    }
}
