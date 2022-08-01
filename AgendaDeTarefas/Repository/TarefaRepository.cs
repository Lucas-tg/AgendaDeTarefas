using AgendaDeTarefas.DataBase;
using AgendaDeTarefas.Models;
using System.Collections.Generic;
using System.Linq;

namespace AgendaDeTarefas.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly TarefaContext _tarefaContext;
        public TarefaRepository(TarefaContext tarefaContext)
        {
            _tarefaContext = tarefaContext; 
        }

        public TarefaModel AdicionarTarefa(TarefaModel tarefa)
        {
            _tarefaContext.Tarefa.Add(tarefa);
            _tarefaContext.SaveChanges();
            return tarefa;
        }

        public bool Apagar(int id)
        {
            TarefaModel tarefaModel = ListarPorId(id);

            if (tarefaModel == null) throw new System.Exception("Erro Deletar Tarefa");
            _tarefaContext.Tarefa.Remove(tarefaModel);
            _tarefaContext.SaveChanges();

            return true;
        }

        public TarefaModel ListarPorId(int id)
        {
          return _tarefaContext.Tarefa.Find(id);
            
        }

        public List<TarefaModel> ListarTarefas()
        {
            return _tarefaContext.Tarefa.ToList();
        }

        public TarefaModel Modificar(TarefaModel tarefa)
        {
            TarefaModel tarefaModel = ListarPorId(tarefa.id);

            if (tarefaModel == null) throw new System.Exception("Erro Modificar Tarefa");

            tarefaModel.titulo = tarefa.titulo;
            tarefaModel.data = tarefa.data;
            tarefaModel.horaInicio = tarefa.horaInicio;
            tarefaModel.horaFim = tarefa.horaFim;
            tarefaModel.prioridade = tarefa.prioridade;
            tarefaModel.finalizada = tarefa.finalizada;

            _tarefaContext.Tarefa.Update(tarefaModel);
            _tarefaContext.SaveChanges();


            return tarefaModel;
        }
    }
}
