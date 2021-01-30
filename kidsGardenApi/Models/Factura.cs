using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Factura
    {
        public Factura()
        {
            Pagos = new HashSet<Pago>();
        }

        public int IdFactura { get; set; }
        public int? SuscripcionId { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Total { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual Suscripcion Suscripcion { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
