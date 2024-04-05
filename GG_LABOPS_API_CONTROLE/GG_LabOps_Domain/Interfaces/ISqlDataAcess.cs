namespace GG_LabOps_Domain.Interfaces
{
    public interface ISqlDataAcess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "SqlDataLocal");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "SqlDataLocal");
    }
}
