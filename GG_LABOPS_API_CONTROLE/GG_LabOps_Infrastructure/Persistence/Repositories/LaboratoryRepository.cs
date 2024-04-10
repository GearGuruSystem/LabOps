using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.DataContext;
using System.Data;
using Dapper;
using GG_LabOps_Infrastructure.Queries;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
    internal class LaboratoryRepository : ILaboratoryRepository
    {
        private readonly ISqlDataAcess sqlData;
        private readonly IDbConnection connection;

        public LaboratoryRepository(ISqlDataAcess sqlData, SqlFactory sqlFactory)
        {
            this.sqlData = sqlData;
            connection = sqlFactory.CreateConnection();
        }

        public Task<IEnumerable<Laboratory>> GetAllAsync()
        {
            var query = LaboratoryQueries.GetAllLaboratory();
            return connection.QueryAsync<Laboratory>(query.Query, query.Parameters);
        }

        public async Task<Laboratory> GetByIdAsync(int id)
        {
            var data = await sqlData.LoadData<Laboratory, dynamic>("", new { id });
            return data.FirstOrDefault();
        }

        public async Task<IEnumerable<Laboratory>> GetByHostnameAsync(string hostname)
        {
            var data = await sqlData.LoadData<Laboratory, dynamic>("", new { hostname });
            return data;
        }

        public async Task<Laboratory> GetByInvetoryAsync(string inventory)
        {
            var data = await sqlData.LoadData<Laboratory, dynamic>("", new { inventory });
            return data.FirstOrDefault();
        }

        public Task<Laboratory> CreateAsync(Laboratory entity)
        {
            sqlData.SaveData("", new { entity });
            return Task.FromResult(entity);
        }

        public Task<Laboratory> UpdateAsync(int id, Laboratory entity)
        {
            sqlData.SaveData("", new { id, entity });
            return Task.FromResult(entity);
        }

        public bool DisableById(int id)
        {
            sqlData.SaveData("", new { id });
            return true;
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
