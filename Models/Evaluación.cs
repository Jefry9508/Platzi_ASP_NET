using System;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_Core.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }

        [Required(ErrorMessage="El Id del alumno es requerido")]
        public string AlumnoId { get; set; }
        public Asignatura Asignatura  { get; set; }

        [Required(ErrorMessage="El Id de la asignatura es requerido")]
        public string AsignaturaId { get; set; }

        [Required(ErrorMessage="La nota de la evaluación es requerida")]
        [Range(0, 10, ErrorMessage="La nota debe estar entre 0 y 10")]
        public float Nota { get; set; }

        // public override string ToString()
        // {
        //     return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        // }
    }
}