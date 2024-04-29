using Bogus;
using GG_LabOps_Domain.DTOs;

namespace GG_LabOps_FakeData.EquipamentData
{
    public class UpdateEquipamentFaker : Faker<UpdateEquipamentDTO>
    {
        public UpdateEquipamentFaker()
        {
            RuleFor(p => p.Inventario, x => x.Random.AlphaNumeric(14));
            RuleFor(p => p.Hostname, x => x.Random.AlphaNumeric(14));
            RuleFor(p => p.NumeroSerie, x => x.Random.AlphaNumeric(15));
            RuleFor(p => p.MarcaId, x => x.Random.Int(1, 10));
            RuleFor(p => p.ModeloId, x => x.Random.Int(1, 10));
            RuleFor(p => p.TipoId, x => x.Random.Int(1, 10));
            RuleFor(p => p.Ativa, x => x.Random.Bool());
        }
    }
}
