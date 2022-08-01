using System.ComponentModel.DataAnnotations;

namespace AgendaDeTarefas.Models
{
    public class TarefaModel
    {

        public int id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string data { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Time)]
        public string horaInicio { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Time)]
        public string horaFim { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string prioridade { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public bool finalizada { get; set; }   


    }
}
