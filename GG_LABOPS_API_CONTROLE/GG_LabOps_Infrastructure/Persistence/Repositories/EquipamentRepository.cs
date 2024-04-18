using Dapper;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.Queries;
using System.Data;

namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
    public class EquipamentRepository : IEquipamentRepository
    {
        private readonly ISqlDataAcess sqlData;
        private readonly IDbConnection connection;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentRepository(ISqlDataAcess sqlData, ISqlFactory factory)
        {
            this.sqlData = sqlData;
            connection = factory.CreateConnection();
        }

        public async Task<IEnumerable<Equipament>> GetAllAsync()
        {
            return await sqlData.LoadData<Equipament, dynamic>("[dbo].[LABOPS_CONSULTA_TODAS_MAQUINAS]", new { });
        }

        public async Task<Equipament> GetByIdAsync(int id)
        {
            QueryModel query = EquipamentQueries.GetAllEquipament();
            IEnumerable<Equipament> response = await connection.QueryAsync<Equipament>(query.Query, query.Parameters);
            return response.FirstOrDefault();
        }

        public async Task<Equipament> CreateAsync(Equipament entity)
        {
            await sqlData.SaveData("[dbo].[LABOPS_CADASTRA_MAQUINATESTE]", new { entity });
            return entity;
        }

        public async Task<Equipament> UpdateAsync(int id, Equipament entity)
        {
            await sqlData.SaveData("", new { id, entity });
            return entity;
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
