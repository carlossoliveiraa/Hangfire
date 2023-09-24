using Hangfire.Application.Interfaces.Repository;
using Hangfire.Application.Interfaces.Service;

namespace Hangfire.Application.Services
{    
    public class TerceiroJobService : ITerceiroJobService
    {
        private readonly ITerceiroJobRepository _terceiroJobRepository;
        public TerceiroJobService(ITerceiroJobRepository terceiroJobRepository)
        {
            _terceiroJobRepository = terceiroJobRepository;
        }
        public async Task ExecuteJobAsync()
        {
            await ExecutarPrimeiroServico();
        }

        private async Task ExecutarPrimeiroServico()
        {
            try
            {
                var dados = await _terceiroJobRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
