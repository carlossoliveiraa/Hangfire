using Hangfire.Application.Domain;
using Hangfire.Application.Interfaces.Repository;

namespace Hangfire.Data.Repository
{
    public class TerceiroJobRepository : Repository<TerceiroJob>, ITerceiroJobRepository
    {
        public async Task<IEnumerable<TerceiroJob>> GetAll()
        {
            // Simulando uma consulta ao banco de dados
            await Task.Delay(100); // Aguarda por 100 milissegundos (apenas para simulação)

            // Dados estáticos de exemplo
            var dados = new List<TerceiroJob>
                    {
                        new TerceiroJob { Id = 1, Nome = "Tarefa 1" },
                        new TerceiroJob { Id = 2, Nome = "Tarefa 2" },
                        new TerceiroJob { Id = 3, Nome = "Tarefa 3" },
                    };

            return dados;
        }
    }
}
