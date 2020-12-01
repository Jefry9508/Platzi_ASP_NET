using System;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_Core.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }

        [Required(ErrorMessage="El nombre es requerido")]
        public virtual string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}