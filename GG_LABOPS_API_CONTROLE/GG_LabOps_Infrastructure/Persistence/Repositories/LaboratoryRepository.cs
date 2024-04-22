using Dapper;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.DataAcess;
using GG_LabOps_Infrastructure.Queries;
using System.Data;


namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
#pragma warning disable IDE0290 // Use primary constructor
    internal class LaboratoryRepository : ILaboratoryRepository
    {
        private readonly ISqlDataAcess sqlData;
        private readonly IDbConnection connection;

        public LaboratoryRepository(ISqlDataAcess sqlData, ISqlFactory sqlFactory)
        {
            this.sqlData = sqlData;
            connection = sqlFactory.CreateConnection();
        }

        public async Task<IEnumerable<Laboratory>> GetAllAsync()
        {
            QueryModel query = LaboratoryQueries.GetAllLaboratory();
            return await connection.QueryAsync<Laboratory>(query.Query, query.Parameters);
        }

        public async Task<Laboratory> GetByIdAsync(int id)
        {
            QueryModel query = LaboratoryQueries.GetLaboratoryById(id);
            return await connection.QueryFirstAsync<Laboratory>(query.Query, query.Parameters);
        }

        public async Task<IEnumerable<Laboratory>> GetByHostnameAsync(string hostname)
        {
            QueryModel query = LaboratoryQueries.GetLaboratoryByHost(hostname);
            return await connection.QueryAsync<Laboratory>(query.Query, query.Parameters);
        }

        public async Task<Laboratory> GetByInvetoryAsync(string inventory)
        {
            QueryModel query = LaboratoryQueries.GetLaboratoryByInv(inventory);
            return await connection.QueryFirstAsync(query.Query, query.Parameters);
        }

        public Task<Laboratory> CreateAsync(Laboratory entity)
        {
            sqlData.SaveDataAsync("", new { entity });
            return Task.FromResult(entity);
        }

        public async Task<Laboratory> UpdateAsync(int id, Laboratory entity)
        {
            await sqlData.SaveDataAsync("", new { id, entity });
            return await Task.FromResult(entity);
        }

        public bool DisableById(int id)
        {
            sqlData.SaveDataAsync("", new { id });
            return true;
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
