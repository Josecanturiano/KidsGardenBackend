using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class ActividadPlanificadaPorEstudiante
    {
        public int IdPlanificacion { get; set; }
        public int? EstudianteId { get; set; }
        public int? ActividadSeccionId { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Calificacion { get; set; }
        public string Retroalimentacion { get; set; }
        public bool? Entrega { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Actividad ActividadSeccion { get; set; }
        public virtual UsuarioPorInstitucion CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual UsuarioPorInstitucion Estudiante { get; set; }
        public virtual UsuarioPorInstitucion ModificadoPorNavigation { get; set; }
    }
}
