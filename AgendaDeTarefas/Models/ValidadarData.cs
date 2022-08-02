using System;
using System.ComponentModel.DataAnnotations;

namespace AgendaDeTarefas.Models
{
    public class ValidadarData
    {
        public static ValidationResult DataNoPassado(DateTime data)
        {
            return DateTime.Compare(data, DateTime.Today) < 0 ? new ValidationResult("Data não pode estar no passado") : ValidationResult.Success;
        }
    }
}