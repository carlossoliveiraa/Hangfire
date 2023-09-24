using Hangfire.Application.Domain;
using Hangfire.Application.Interfaces.Repository;

namespace Hangfire.Data.Repository
{
    public class QuartoJobRepository : Repository<QuartoJob>, IQuartoJobRepository
    {
        public async Task<IEnumerable<QuartoJob>> GetAll()
        {
            // Simulando uma consulta ao banco de dados
            await Task.Delay(100); // Aguarda por 100 milissegundos (apenas para simulação)

            // Dados estáticos de exemplo
            var dados = new List<QuartoJob>
                    {
                        new QuartoJob { Id = 1, Nome = "Tarefa 1" },
                        new QuartoJob { Id = 2, Nome = "Tarefa 2" },
                        new QuartoJob { Id = 3, Nome = "Tarefa 3" },
                    };

            return dados;
        }
    }
}
