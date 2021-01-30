using System;
using System.Collections.Generic;
using Newtonsoft.Json;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Persona
    {
        public Persona()
        {
            DistritoCreadoPorNavigations = new HashSet<Distrito>();
            DistritoModificadoPorNavigations = new HashSet<Distrito>();
            EstadoCreadoPorNavigations = new HashSet<Estado>();
            EstadoModificadoPorNavigations = new HashSet<Estado>();
            FacturaCreadoPorNavigations = new HashSet<Factura>();
            FacturaModificadoPorNavigations = new HashSet<Factura>();
            GeneroCreadoPorNavigations = new HashSet<Genero>();
            GeneroModificadoPorNavigations = new HashSet<Genero>();
            GestorDeContenidoCreadoPorNavigations = new HashSet<GestorDeContenido>();
            GestorDeContenidoModificadoPorNavigations = new HashSet<GestorDeContenido>();
            GestorDeContenidoPersonas = new HashSet<GestorDeContenido>();
            InstitucionCreadoPorNavigations = new HashSet<Institucion>();
            InstitucionModificadoPorNavigations = new HashSet<Institucion>();
            InverseCreadoPorNavigation = new HashSet<Persona>();
            InverseModificadoPorNavigation = new HashSet<Persona>();
            PagoCreadoPorNavigations = new HashSet<Pago>();
            PagoModificadoPorNavigations = new HashSet<Pago>();
            RangoDeSuscripcionCreadoPorNavigations = new HashSet<RangoDeSuscripcion>();
            RangoDeSuscripcionModificadoPorNavigations = new HashSet<RangoDeSuscripcion>();
            RegionalCreadoPorNavigations = new HashSet<Regional>();
            RegionalModificadoPorNavigations = new HashSet<Regional>();
            SuscripcionCreadoPorNavigations = new HashSet<Suscripcion>();
            SuscripcionModificadoPorNavigations = new HashSet<Suscripcion>();
            TipoLicenciumCreadoPorNavigations = new HashSet<TipoLicencium>();
            TipoLicenciumModificadoPorNavigations = new HashSet<TipoLicencium>();
            TutorYEstudiantes = new HashSet<TutorYEstudiante>();
            UsuarioPorInstitucions = new HashSet<UsuarioPorInstitucion>();
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public int? GeneroId { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public string Foto { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        [JsonIgnore]
        public virtual Persona CreadoPorNavigation { get; set; }
        [JsonIgnore]
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Genero Genero { get; set; }
        [JsonIgnore]
        public virtual Persona ModificadoPorNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<Distrito> DistritoCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Distrito> DistritoModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Estado> EstadoCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Estado> EstadoModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Factura> FacturaCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Factura> FacturaModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Genero> GeneroCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Genero> GeneroModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<GestorDeContenido> GestorDeContenidoCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<GestorDeContenido> GestorDeContenidoModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<GestorDeContenido> GestorDeContenidoPersonas { get; set; }
        [JsonIgnore]
        public virtual ICollection<Institucion> InstitucionCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Institucion> InstitucionModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Persona> InverseCreadoPorNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<Persona> InverseModificadoPorNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<Pago> PagoCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Pago> PagoModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<RangoDeSuscripcion> RangoDeSuscripcionCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<RangoDeSuscripcion> RangoDeSuscripcionModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Regional> RegionalCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Regional> RegionalModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Suscripcion> SuscripcionCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Suscripcion> SuscripcionModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<TipoLicencium> TipoLicenciumCreadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<TipoLicencium> TipoLicenciumModificadoPorNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<TutorYEstudiante> TutorYEstudiantes { get; set; }
        [JsonIgnore]
        public virtual ICollection<UsuarioPorInstitucion> UsuarioPorInstitucions { get; set; }
    }
}
