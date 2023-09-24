using Hangfire.Application.Domain;

namespace Hangfire.Application.Interfaces.Repository
{
    public interface IPrimeiroJobRepository : IRepository<PrimeiroJob>
    {
       Task <IEnumerable<PrimeiroJob>> GetAll();
    }
}
