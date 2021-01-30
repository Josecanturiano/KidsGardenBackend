using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Grado
    {
        public Grado()
        {
            Actividads = new HashSet<Actividad>();
            Seccions = new HashSet<Seccion>();
        }

        public int IdGrado { get; set; }
        public string Nombre { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual UsuarioPorInstitucion CreadoPorNavigation { get; set; }
        public virtual UsuarioPorInstitucion ModificadoPorNavigation { get; set; }
        public virtual ICollection<Actividad> Actividads { get; set; }
        public virtual ICollection<Seccion> Seccions { get; set; }
    }
}
