using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Regional
    {
        public Regional()
        {
            Distritos = new HashSet<Distrito>();
        }

        public int IdRegional { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Director { get; set; }
        public string Telefono { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual ICollection<Distrito> Distritos { get; set; }
    }
}
