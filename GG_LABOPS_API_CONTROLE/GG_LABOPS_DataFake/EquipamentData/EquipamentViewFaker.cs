using Bogus;
using GG_LabOps_Domain.DTOs;

namespace GG_LabOps_FakeData.EquipamentData
{
    public class EquipamentViewFaker : Faker<ViewEquipamentDTO>
    {
        public EquipamentViewFaker()
        {
            RuleFor(p => p.Id, x => new Faker().Random.Number(1, 999999));
            RuleFor(p => p.Inventario, x => x.Random.AlphaNumeric(14));
            RuleFor(p => p.Hostname, x => x.Random.AlphaNumeric(14));
            RuleFor(p => p.NumeroSerie, x => x.Random.AlphaNumeric(15));
            RuleFor(p => p.Ativa, x => x.Random.Bool());
            RuleFor(p => p.MarcaNome, x => x.Random.AlphaNumeric(20));
            RuleFor(p => p.ModeloNome, x => x.Random.AlphaNumeric(20));
            RuleFor(p => p.TipoNome, x => x.Random.AlphaNumeric(20));
            RuleFor(p => p.DataRegistro, x => x.Date.Past());
            RuleFor(p => p.UltimaAtualizacao, x => x.Date.Past());
        }
    }
}
