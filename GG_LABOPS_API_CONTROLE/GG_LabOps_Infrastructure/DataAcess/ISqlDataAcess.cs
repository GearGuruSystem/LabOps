namespace GG_LabOps_Infrastructure.DataAcess
{
    public interface ISqlDataAcess
    {
        Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionName = "SqlDataLocal");
        Task SaveDataAsync<T>(string storedProcedure, T parameters, string connectionName = "SqlDataLocal");
    }
}
