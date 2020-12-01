using System;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_Core.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        [Required(ErrorMessage="El Id del curso es requerido")]
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}