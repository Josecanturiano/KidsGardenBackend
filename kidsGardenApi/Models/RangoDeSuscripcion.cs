using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class RangoDeSuscripcion
    {
        public RangoDeSuscripcion()
        {
            Suscripcions = new HashSet<Suscripcion>();
        }

        public int IdRango { get; set; }
        public int? TipoLicenciaId { get; set; }
        public string Descripcion { get; set; }
        public int? DuracionDias { get; set; }
        public decimal? Precio { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual TipoLicencium TipoLicencia { get; set; }
        public virtual ICollection<Suscripcion> Suscripcions { get; set; }
    }
}
