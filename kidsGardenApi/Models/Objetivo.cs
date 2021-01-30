using System;
using System.Collections.Generic;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class Objetivo
    {
        public int IdObjetivo { get; set; }
        public string Descripcion { get; set; }
        public int? CreadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual GestorDeContenido CreadoPorNavigation { get; set; }
        public virtual GestorDeContenido ModificadoPorNavigation { get; set; }
    }
}
