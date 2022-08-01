using AgendaDeTarefas.Models;
using System.Collections.Generic;

namespace AgendaDeTarefas.Repository
{
    public interface ITarefaRepository
    {
        // Apaga Tarefa pelo id
        bool Apagar (int id);

        // Modifica tarefa ja existente
        TarefaModel Modificar(TarefaModel tarefa);

        // Lista tarefas pelo id - usado para Editar Tarefas
        TarefaModel ListarPorId (int id);

        // Lista todas as Tarefas
        List<TarefaModel> ListarTarefas();

        // Adiciona nova Tarefa
        TarefaModel AdicionarTarefa(TarefaModel tarefa);
    }
}
