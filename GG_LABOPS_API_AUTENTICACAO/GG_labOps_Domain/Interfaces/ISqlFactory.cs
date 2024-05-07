namespace GG_labOps_Domain.Interfaces
{
    public interface ISqlFactory
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "AppDataContext");

        Task<Task> SaveData<T>(string storedProcedure, T parameters, string connectionName = "AppDataContext");
    }
}