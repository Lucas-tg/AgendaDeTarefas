using AgendaDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeTarefas.DataBase  
{
    // https://docs.microsoft.com/pt-br/ef/core/dbcontext-configuration/
    public class TarefaContext : DbContext
    {

        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }
        // cria tabela Tarefa com os atributos definidos em TarefaModel
        public DbSet<TarefaModel> Tarefa { get; set; }

    }
}
