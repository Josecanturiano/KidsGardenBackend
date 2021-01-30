using kidsGardenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace kidsGardenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly kidsGardenContext _context;

        public LoginController(IConfiguration config, kidsGardenContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost]
        public dynamic Login(LoginModel loginModel)
        {
            if(loginModel.Username != null && loginModel.Password != null)
            {
                var usuario = _context.UsuarioPorInstitucions.First(x => x.CodigoUsuario == loginModel.Username && x.Contrasena == loginModel.Password);

                if (usuario == null)
                {
                    return BadRequest("Invalid credentials");
                }

                var persona = _context.Personas.Find(usuario.PersonaId);

                var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("LastName", persona.Apellido),
                    new Claim("Name", persona.Nombre)
                   };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));

            }
            else
            {
                return Request.Body;
            }        
        }
    }
}
