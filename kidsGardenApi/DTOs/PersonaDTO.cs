using System;
namespace kidsGardenApi.DTOs
{
    public class PersonaDTO
    {
        public PersonaDTO()
        {

        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public string Foto { get; set; }
        public int IdUsuario { get; set; }
        public int? PersonaId { get; set; }
        public string CodigoUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public string Institucion { get; set; }
        public string Rol { get; set; }
        public int? SeccionId { get; set; }
    }
}
