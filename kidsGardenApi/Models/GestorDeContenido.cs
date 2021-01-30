using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class GestorDeContenido
    {
        public GestorDeContenido()
        {
            ActividadCreadoPorNavigations = new HashSet<Actividad>();
            ActividadModificadoPorNavigations = new HashSet<Actividad>();
            CompetenciumCreadoPorNavigations = new HashSet<Competencium>();
            CompetenciumModificadoPorNavigations = new HashSet<Competencium>();
            ImageneCreadoPorNavigations = new HashSet<Imagene>();
            ImageneModificadoPorNavigations = new HashSet<Imagene>();
            ImagenesActividadCreadoPorNavigations = new HashSet<ImagenesActividad>();
            ImagenesActividadModificadoPorNavigations = new HashSet<ImagenesActividad>();
            MecanicaDeActividadCreadoPorNavigations = new HashSet<MecanicaDeActividad>();
            MecanicaDeActividadModificadoPorNavigations = new HashSet<MecanicaDeActividad>();
            ObjetivoCreadoPorNavigations = new HashSet<Objetivo>();
            ObjetivoModificadoPorNavigations = new HashSet<Objetivo>();
        }

        public int IdGestor { get; set; }
        public int? PersonaId { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Actividad> ActividadCreadoPorNavigations { get; set; }
        public virtual ICollection<Actividad> ActividadModificadoPorNavigations { get; set; }
        public virtual ICollection<Competencium> CompetenciumCreadoPorNavigations { get; set; }
        public virtual ICollection<Competencium> CompetenciumModificadoPorNavigations { get; set; }
        public virtual ICollection<Imagene> ImageneCreadoPorNavigations { get; set; }
        public virtual ICollection<Imagene> ImageneModificadoPorNavigations { get; set; }
        public virtual ICollection<ImagenesActividad> ImagenesActividadCreadoPorNavigations { get; set; }
        public virtual ICollection<ImagenesActividad> ImagenesActividadModificadoPorNavigations { get; set; }
        public virtual ICollection<MecanicaDeActividad> MecanicaDeActividadCreadoPorNavigations { get; set; }
        public virtual ICollection<MecanicaDeActividad> MecanicaDeActividadModificadoPorNavigations { get; set; }
        public virtual ICollection<Objetivo> ObjetivoCreadoPorNavigations { get; set; }
        public virtual ICollection<Objetivo> ObjetivoModificadoPorNavigations { get; set; }
    }
}
