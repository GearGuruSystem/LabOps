using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.LabOps.Infrastructure.Data.DataAcess
{
    public interface ISqlData
    {
        //Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionName = "SqlDataLocal");
        //Task<Task> SaveDataAsync<T>(string storedProcedure, T parameters, string connectionName = "SqlDataLocal");
        Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters);
        Task<Task> SaveDataAsync<T>(string storedProcedure, T parameters);
    }
}
