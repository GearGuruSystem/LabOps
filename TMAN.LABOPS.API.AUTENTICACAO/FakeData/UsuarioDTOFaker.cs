using Auth.LabOps.Application.DTOs.DTOs.Usuario;
using Bogus;

namespace FakeData
{
    public class UsuarioDTOFaker : Faker<UsuarioDTO>
    {
        public UsuarioDTOFaker()
        {
            RuleFor(p => p.IDUsuario, x => new Faker().Random.Number(1, 99999));
            RuleFor(p => p.Login, x => new Faker().Random.AlphaNumeric(10));
            RuleFor(p => p.Senha, x => x.Random.AlphaNumeric(25));
            RuleFor(p => p.InseridoEm, x => x.Date.Past());
            RuleFor(p => p.AtualizadoEm, x => x.Date.Past());
        }
    }
}
