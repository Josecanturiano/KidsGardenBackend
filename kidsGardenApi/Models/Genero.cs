using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdGenero { get; set; }
        public string Nombre { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
