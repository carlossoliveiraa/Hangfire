using Hangfire.Application.Domain;
using Hangfire.Application.Interfaces.Repository;

namespace Hangfire.Data.Repository
{
    public class PrimeiroJobRepository : Repository<PrimeiroJob>, IPrimeiroJobRepository
    {
        public async Task<IEnumerable<PrimeiroJob>> GetAll()
        {
            // Simulando uma consulta ao banco de dados
            await Task.Delay(100); // Aguarda por 100 milissegundos (apenas para simulação)

            // Dados estáticos de exemplo
            var dados = new List<PrimeiroJob>
                    {
                        new PrimeiroJob { Id = 1, Nome = "Tarefa 1" },
                        new PrimeiroJob { Id = 2, Nome = "Tarefa 2" },
                        new PrimeiroJob { Id = 3, Nome = "Tarefa 3" },
                    };

            return dados;
        }
    }
}
