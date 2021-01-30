using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Pago
    {
        public int IdPago { get; set; }
        public int? FacturaId { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Estado { get; set; }
        public decimal? MontoTotal { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
    }
}
