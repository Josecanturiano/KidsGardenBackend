using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Role
    {
        public Role()
        {
            UsuarioPorInstitucions = new HashSet<UsuarioPorInstitucion>();
        }

        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual UsuarioPorInstitucion CreadoPorNavigation { get; set; }
        public virtual UsuarioPorInstitucion ModificadoPorNavigation { get; set; }
        public virtual ICollection<UsuarioPorInstitucion> UsuarioPorInstitucions { get; set; }
    }
}
