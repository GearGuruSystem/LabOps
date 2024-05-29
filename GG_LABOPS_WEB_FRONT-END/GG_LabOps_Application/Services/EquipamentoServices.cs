using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Application.Services
{
    public class EquipamentoServices : IEquipamentoServices
    {
        private readonly IEquipamentoApiClient client;

        public EquipamentoServices(IEquipamentoApiClient client)
        {
            this.client = client;
        }

        public async Task<Equipamento> BuscarTodos()
        {
            return await client.BuscarTodos();
        }

        public async Task<Equipamento> BuscarPorId(int id)
        {
            return await client.BuscaPorId(id);
        }
    }
}
