using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Imagene
    {
        public Imagene()
        {
            ImagenesActividads = new HashSet<ImagenesActividad>();
        }

        public int IdImagen { get; set; }
        public string ImageUrl { get; set; }
        public string Descripcion { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual GestorDeContenido CreadoPorNavigation { get; set; }
        public virtual GestorDeContenido ModificadoPorNavigation { get; set; }
        public virtual ICollection<ImagenesActividad> ImagenesActividads { get; set; }
    }
}
