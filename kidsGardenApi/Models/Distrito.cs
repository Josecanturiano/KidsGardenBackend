using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Institucions = new HashSet<Institucion>();
        }

        public int IdDistrito { get; set; }
        public int? Regional { get; set; }
        public string Distrito1 { get; set; }
        public string Direccion { get; set; }
        public string Director { get; set; }
        public string Telefono { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual Regional RegionalNavigation { get; set; }
        public virtual ICollection<Institucion> Institucions { get; set; }
    }
}
