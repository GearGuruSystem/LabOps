using GG_LabOps_Infra.Useful;

namespace GG_LabOps_Infra.Interfaces
{
    public interface IApiClient<T> where T : class
    {
        public Task<T> BuscarTodos();
        public Task<T> BuscaPorId(int id);
    }
}
