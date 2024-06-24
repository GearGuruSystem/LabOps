namespace Auth.LabOps.Infrastructure.Data.DataAcess
{
    public interface ISqlData
    {
        Task<Task> SaveDataAsync<T>(string storedProcedure, T parameters, string connectionName = "AppDataConnection");
        Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U? parameters = null, string connectionName = "AppDataConnection") where U : class;
    }
}
