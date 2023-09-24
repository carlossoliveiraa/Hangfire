using Hangfire.Application.Interfaces.Repository;
using Hangfire.Application.Interfaces.Service;

namespace Hangfire.Application.Services
{  

    public class QuartoJobService : IQuartoJobService
    {
        private readonly IQuartoJobRepository _quartoJobRepository;
        public QuartoJobService(IQuartoJobRepository quartoJobRepository)
        {
            _quartoJobRepository = quartoJobRepository;
        }
        public async Task ExecuteJobAsync()
        {
            await ExecutarPrimeiroServico();
        }

        private async Task ExecutarPrimeiroServico()
        {
            try
            {
                var dados = await _quartoJobRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
