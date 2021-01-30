using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Estado
    {
        public Estado()
        {
            ActividadPlanificadaPorEstudiantes = new HashSet<ActividadPlanificadaPorEstudiante>();
            ActividadPlanificadaPorSeccions = new HashSet<ActividadPlanificadaPorSeccion>();
            Actividads = new HashSet<Actividad>();
            Facturas = new HashSet<Factura>();
            GestorDeContenidos = new HashSet<GestorDeContenido>();
            ImagenesActividads = new HashSet<ImagenesActividad>();
            Institucions = new HashSet<Institucion>();
            Pagos = new HashSet<Pago>();
            Personas = new HashSet<Persona>();
            RangoDeSuscripcions = new HashSet<RangoDeSuscripcion>();
            Suscripcions = new HashSet<Suscripcion>();
            TipoLicencia = new HashSet<TipoLicencium>();
            TutorYEstudiantes = new HashSet<TutorYEstudiante>();
            UsuarioPorInstitucions = new HashSet<UsuarioPorInstitucion>();
        }

        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Persona CreadoPorNavigation { get; set; }
        public virtual Persona ModificadoPorNavigation { get; set; }
        public virtual ICollection<ActividadPlanificadaPorEstudiante> ActividadPlanificadaPorEstudiantes { get; set; }
        public virtual ICollection<ActividadPlanificadaPorSeccion> ActividadPlanificadaPorSeccions { get; set; }
        public virtual ICollection<Actividad> Actividads { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<GestorDeContenido> GestorDeContenidos { get; set; }
        public virtual ICollection<ImagenesActividad> ImagenesActividads { get; set; }
        public virtual ICollection<Institucion> Institucions { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<RangoDeSuscripcion> RangoDeSuscripcions { get; set; }
        public virtual ICollection<Suscripcion> Suscripcions { get; set; }
        public virtual ICollection<TipoLicencium> TipoLicencia { get; set; }
        public virtual ICollection<TutorYEstudiante> TutorYEstudiantes { get; set; }
        public virtual ICollection<UsuarioPorInstitucion> UsuarioPorInstitucions { get; set; }
    }
}
