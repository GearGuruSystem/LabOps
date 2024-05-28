using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Domain.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Domain.Services.Security
{
    public class ServiceToken : IServiceToken
    {
        private readonly IConfiguration configuration;

        public ServiceToken(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GerarToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            //PESQUISAR SOBRE ARMAZENAMENTO DE SEGREDOS/SENHAS NA NUVEM (ATUALMENTE UTILIZANDO NO APPSETTINGS [NAO RECOMENDADO])
            var chave = Encoding.ASCII.GetBytes(configuration.GetSection("JWT:Secret").Value);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.Login)
            };
            claims.AddRange(usuario.UsuarioXGrupoUsuarios
                .SelectMany(x => x.GrupoUsuario.GrupoUsuarioXAplicacoes)
                .Select(y => new Claim(ClaimTypes.Role, y.Permissao)));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Audience = configuration.GetSection("JWT:Audience").Value,
                Issuer = configuration.GetSection("JWT:Issuer").Value,
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToInt32(configuration.GetSection("JWT:ExpiraEmMinutos").Value)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha512Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}