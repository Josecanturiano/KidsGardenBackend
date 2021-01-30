using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class TipoLicencium
    {
        public TipoLicencium()
        {
            RangoDeSuscripcions = new HashSet<RangoDeSuscripcion>();
        }

        public int IdLicencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual ICollection<RangoDeSuscripcion> RangoDeSuscripcions { get; set; }
    }
}
