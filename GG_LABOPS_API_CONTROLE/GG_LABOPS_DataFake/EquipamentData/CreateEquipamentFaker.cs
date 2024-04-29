using Bogus;
using GG_LabOps_Domain.DTOs;

namespace GG_LabOps_FakeData.EquipamentData
{
    public class CreateEquipamentFaker : Faker<CreateEquipamentDTO>
    {
        public CreateEquipamentFaker()
        {
            RuleFor(p => p.Inventario, x => x.Random.AlphaNumeric(14));
            RuleFor(p => p.Hostname, x => x.Random.AlphaNumeric(14));
            RuleFor(p => p.NumeroSerie, x => x.Random.AlphaNumeric(15));
            RuleFor(p => p.Ativa, x => x.Random.Bool());
            RuleFor(p => p.MarcaId, x => x.Random.Int());
            RuleFor(p => p.ModeloId, x => x.Random.Int());
            RuleFor(p => p.TipoId, x => x.Random.Int());
        }
    }
}
