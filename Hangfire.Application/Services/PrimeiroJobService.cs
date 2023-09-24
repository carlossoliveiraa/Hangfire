using Hangfire.Application.Interfaces.Repository;
using Hangfire.Application.Interfaces.Service;

namespace Hangfire.Application.Services
{
    public class PrimeiroJobService : IPrimeiroJobService
    {
        private readonly IPrimeiroJobRepository _primeiroJobRepository;
        public PrimeiroJobService(IPrimeiroJobRepository primeiroJobRepository)
        {
            _primeiroJobRepository = primeiroJobRepository;
        }
        public async Task ExecuteJobAsync()
        {
           await ExecutarPrimeiroServico();
        }

        private async Task ExecutarPrimeiroServico()
        {
            try
            {
               var dados = await _primeiroJobRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
