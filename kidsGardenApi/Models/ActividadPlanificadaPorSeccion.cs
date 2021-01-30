using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class ActividadPlanificadaPorSeccion
    {
        public int IdPlanificacion { get; set; }
        public int? SeccionId { get; set; }
        public int? ActividadId { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Actividad Actividad { get; set; }
        public virtual UsuarioPorInstitucion CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual UsuarioPorInstitucion ModificadoPorNavigation { get; set; }
        public virtual Seccion Seccion { get; set; }
    }
}
