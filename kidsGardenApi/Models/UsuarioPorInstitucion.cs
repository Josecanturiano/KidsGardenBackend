using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class UsuarioPorInstitucion
    {
        public UsuarioPorInstitucion()
        {
            ActividadPlanificadaPorEstudianteCreadoPorNavigations = new HashSet<ActividadPlanificadaPorEstudiante>();
            ActividadPlanificadaPorEstudianteEstudiantes = new HashSet<ActividadPlanificadaPorEstudiante>();
            ActividadPlanificadaPorEstudianteModificadoPorNavigations = new HashSet<ActividadPlanificadaPorEstudiante>();
            ActividadPlanificadaPorSeccionCreadoPorNavigations = new HashSet<ActividadPlanificadaPorSeccion>();
            ActividadPlanificadaPorSeccionModificadoPorNavigations = new HashSet<ActividadPlanificadaPorSeccion>();
            GradoCreadoPorNavigations = new HashSet<Grado>();
            GradoModificadoPorNavigations = new HashSet<Grado>();
            InverseCreadoPorNavigation = new HashSet<UsuarioPorInstitucion>();
            InverseModificadoPorNavigation = new HashSet<UsuarioPorInstitucion>();
            RoleCreadoPorNavigations = new HashSet<Role>();
            RoleModificadoPorNavigations = new HashSet<Role>();
            SeccionCreadoPorNavigations = new HashSet<Seccion>();
            SeccionModificadoPorNavigations = new HashSet<Seccion>();
            TutorYEstudianteCreadoPorNavigations = new HashSet<TutorYEstudiante>();
            TutorYEstudianteEstudiantes = new HashSet<TutorYEstudiante>();
            TutorYEstudianteModificadoPorNavigations = new HashSet<TutorYEstudiante>();
        }

        public int IdUsuario { get; set; }
        public int? PersonaId { get; set; }
        public string CodigoUsuario { get; set; }
        public string Contrasena { get; set; }
        public int? Estado { get; set; }
        public int? InstitucionId { get; set; }
        public int? RolId { get; set; }
        public int? SeccionId { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual UsuarioPorInstitucion CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual UsuarioPorInstitucion ModificadoPorNavigation { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Role Rol { get; set; }
        public virtual Seccion Seccion { get; set; }
        public virtual ICollection<ActividadPlanificadaPorEstudiante> ActividadPlanificadaPorEstudianteCreadoPorNavigations { get; set; }
        public virtual ICollection<ActividadPlanificadaPorEstudiante> ActividadPlanificadaPorEstudianteEstudiantes { get; set; }
        public virtual ICollection<ActividadPlanificadaPorEstudiante> ActividadPlanificadaPorEstudianteModificadoPorNavigations { get; set; }
        public virtual ICollection<ActividadPlanificadaPorSeccion> ActividadPlanificadaPorSeccionCreadoPorNavigations { get; set; }
        public virtual ICollection<ActividadPlanificadaPorSeccion> ActividadPlanificadaPorSeccionModificadoPorNavigations { get; set; }
        public virtual ICollection<Grado> GradoCreadoPorNavigations { get; set; }
        public virtual ICollection<Grado> GradoModificadoPorNavigations { get; set; }
        public virtual ICollection<UsuarioPorInstitucion> InverseCreadoPorNavigation { get; set; }
        public virtual ICollection<UsuarioPorInstitucion> InverseModificadoPorNavigation { get; set; }
        public virtual ICollection<Role> RoleCreadoPorNavigations { get; set; }
        public virtual ICollection<Role> RoleModificadoPorNavigations { get; set; }
        public virtual ICollection<Seccion> SeccionCreadoPorNavigations { get; set; }
        public virtual ICollection<Seccion> SeccionModificadoPorNavigations { get; set; }
        public virtual ICollection<TutorYEstudiante> TutorYEstudianteCreadoPorNavigations { get; set; }
        public virtual ICollection<TutorYEstudiante> TutorYEstudianteEstudiantes { get; set; }
        public virtual ICollection<TutorYEstudiante> TutorYEstudianteModificadoPorNavigations { get; set; }
    }
}
