using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class ImagenesActividad
    {
        public int IdImagenesActividad { get; set; }
        public int? ActividadId { get; set; }
        public int? ImagenId { get; set; }
        public int? Estado { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual Actividad Actividad { get; set; }
        public virtual GestorDeContenido CreadoPorNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Imagene Imagen { get; set; }
        public virtual GestorDeContenido ModificadoPorNavigation { get; set; }
    }
}
