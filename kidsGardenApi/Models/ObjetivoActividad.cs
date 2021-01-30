using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class ObjetivoActividad
    {
        public int IdObjetivoActividad { get; set; }
        public int? ObjetivoId { get; set; }
        public int? ActividadId { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Actividad Actividad { get; set; }
        public virtual GestorDeContenido CreadoPorNavigation { get; set; }
        public virtual GestorDeContenido ModificadoPorNavigation { get; set; }
        public virtual Objetivo Objetivo { get; set; }
    }
}
