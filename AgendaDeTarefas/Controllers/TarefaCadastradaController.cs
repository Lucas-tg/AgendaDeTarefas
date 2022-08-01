using AgendaDeTarefas.Models;
using AgendaDeTarefas.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

// MainScreen
namespace AgendaDeTarefas.Controllers
{
    public class TarefaCadastradaController : Controller
    {
        private readonly ITarefaRepository _trefaRepository;
        public TarefaCadastradaController(ITarefaRepository tarefaRepository)
        {
            _trefaRepository = tarefaRepository;
        }

        public IActionResult Index()
        {
          List<TarefaModel> tarefa =  _trefaRepository.ListarTarefas();
            return View(tarefa);
        }

        public IActionResult TarefaDetalhada()
        {
            return View();
        }


        public IActionResult NovaTarefa()
        {
            return View();
        }

        public IActionResult EditarTarefa(int id)
        {
          TarefaModel tarefa = _trefaRepository.ListarPorId(id);
            return View(tarefa);
        }

        public IActionResult DeletarTarefa(int id)
        {
            TarefaModel tarefa = _trefaRepository.ListarPorId(id);
            return View(tarefa);
        }



        public IActionResult Deletar(int id)
        {
            _trefaRepository.Apagar(id);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult NovaTarefa(TarefaModel tarefa)
        {
            if(ModelState.IsValid)
            {           
            _trefaRepository.AdicionarTarefa(tarefa);
            return RedirectToAction("Index");
            }
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult ModificarTarefa(TarefaModel tarefa)
        {
            if (ModelState.IsValid)
            {
                _trefaRepository.Modificar(tarefa);
                return RedirectToAction("Index");
            }
            // return View(tarefa); // error ao Editar Tarefa
            return View("EditarTarefa", tarefa);

        }
    }
}
