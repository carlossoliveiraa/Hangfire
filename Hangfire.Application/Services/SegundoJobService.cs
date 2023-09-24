using Hangfire.Application.Interfaces.Repository;
using Hangfire.Application.Interfaces.Service;

namespace Hangfire.Application.Services
{   
    public class SegundoJobService : ISegundoJobService
    {
        private readonly ISegundoJobRepository _segundoJobRepository;
        public SegundoJobService(ISegundoJobRepository segundoJobRepository)
        {
            _segundoJobRepository = segundoJobRepository;
        }
        public async Task ExecuteJobAsync()
        {
            await ExecutarPrimeiroServico();
        }

        private async Task ExecutarPrimeiroServico()
        {
            try
            {
                var dados = await _segundoJobRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
