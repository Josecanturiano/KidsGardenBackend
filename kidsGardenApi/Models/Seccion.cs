using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Seccion
    {
        public Seccion()
        {
            ActividadPlanificadaPorSeccions = new HashSet<ActividadPlanificadaPorSeccion>();
            UsuarioPorInstitucions = new HashSet<UsuarioPorInstitucion>();
        }

        public int IdSeccion { get; set; }
        public string Nombre { get; set; }
        public int? InstitucionId { get; set; }
        public int? GradoId { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual UsuarioPorInstitucion CreadoPorNavigation { get; set; }
        public virtual Grado Grado { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual UsuarioPorInstitucion ModificadoPorNavigation { get; set; }
        public virtual ICollection<ActividadPlanificadaPorSeccion> ActividadPlanificadaPorSeccions { get; set; }
        public virtual ICollection<UsuarioPorInstitucion> UsuarioPorInstitucions { get; set; }
    }
}
