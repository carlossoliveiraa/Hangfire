using Hangfire.Application.Domain;

namespace Hangfire.Application.Interfaces.Repository
{
    public interface ISegundoJobRepository : IRepository<SegundoJob>
    {
        Task<IEnumerable<SegundoJob>> GetAll();
    }
}
