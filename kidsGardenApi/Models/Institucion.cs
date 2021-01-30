using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Institucion
    {
        public Institucion()
        {
            Seccions = new HashSet<Seccion>();
            UsuarioPorInstitucions = new HashSet<UsuarioPorInstitucion>();
        }

        public int IdInstitucion { get; set; }
        public string Nombre { get; set; }
        public int? SuscripcionId { get; set; }
        public int? DistritoId { get; set; }
        public int? Estado { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual Suscripcion Suscripcion { get; set; }
        public virtual ICollection<Seccion> Seccions { get; set; }
        public virtual ICollection<UsuarioPorInstitucion> UsuarioPorInstitucions { get; set; }
    }
}
