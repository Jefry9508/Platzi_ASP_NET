using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_Core.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage="El nombre del curso es requerido")]
        [StringLength(5)]
        public override string Nombre { get => base.Nombre; set => base.Nombre = value; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        [Required(ErrorMessage="La dirección del curso es requerido")]
        [MinLength(4, ErrorMessage="La longitud minima de la dirección es de 4 caracteres")]
        [Display(Prompt="Dirección de correspondencia", Name="Direccion")]
        public string Dirección { get; set; }

        public string EscuelaId { get; set; }

        public Escuela Escuela { get; set; }
    }
}