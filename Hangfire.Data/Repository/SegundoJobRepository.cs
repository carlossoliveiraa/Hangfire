using Hangfire.Application.Domain;
using Hangfire.Application.Interfaces.Repository;

namespace Hangfire.Data.Repository
{
    public class SegundoJobRepository : Repository<SegundoJob>, ISegundoJobRepository
    {
        public async Task<IEnumerable<SegundoJob>> GetAll()
        {
            // Simulando uma consulta ao banco de dados
            await Task.Delay(100); // Aguarda por 100 milissegundos (apenas para simulação)

            // Dados estáticos de exemplo
            var dados = new List<SegundoJob>
                    {
                        new SegundoJob { Id = 1, Nome = "Tarefa 1" },
                        new SegundoJob { Id = 2, Nome = "Tarefa 2" },
                        new SegundoJob { Id = 3, Nome = "Tarefa 3" },
                    };

            return dados;
        }
    }
}
