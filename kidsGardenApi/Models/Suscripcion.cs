using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Suscripcion
    {
        public Suscripcion()
        {
            Facturas = new HashSet<Factura>();
            Institucions = new HashSet<Institucion>();
        }

        public int IdSuscripcion { get; set; }
        public int? RangoId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual RangoDeSuscripcion Rango { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Institucion> Institucions { get; set; }
    }
}
