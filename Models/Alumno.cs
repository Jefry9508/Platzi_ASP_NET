using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_Core.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; }
        public Curso Curso { get; set; }
        
        [Required(ErrorMessage="El Id del curso es requerido")]
        public string CursoId { get; set; }
    }
}