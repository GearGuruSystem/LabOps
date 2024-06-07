using GG_LabOps_Domain.Entities;
using GG_LabOps_Infra.Interfaces;

namespace GG_LabOps_Infra.Handlers
{
    public class HandlerEquipamento : IApiClient<Equipamento>
    {
        public Task<Equipamento> BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Equipamento> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
