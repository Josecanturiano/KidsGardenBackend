using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Actividad
    {
        public Actividad()
        {
            ActividadPlanificadaPorEstudiantes = new HashSet<ActividadPlanificadaPorEstudiante>();
            ActividadPlanificadaPorSeccions = new HashSet<ActividadPlanificadaPorSeccion>();
            ImagenesActividads = new HashSet<ImagenesActividad>();
        }

        public int IdActividad { get; set; }
        public int? GradoId { get; set; }
        public int? MecanicaId { get; set; }
        public int? CompetenciaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ContenidoJson { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Competencium Competencia { get; set; }
        public virtual GestorDeContenido CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Grado Grado { get; set; }
        public virtual MecanicaDeActividad Mecanica { get; set; }
        public virtual GestorDeContenido ModificadoPorNavigation { get; set; }
        public virtual ICollection<ActividadPlanificadaPorEstudiante> ActividadPlanificadaPorEstudiantes { get; set; }
        public virtual ICollection<ActividadPlanificadaPorSeccion> ActividadPlanificadaPorSeccions { get; set; }
        public virtual ICollection<ImagenesActividad> ImagenesActividads { get; set; }
    }
}
