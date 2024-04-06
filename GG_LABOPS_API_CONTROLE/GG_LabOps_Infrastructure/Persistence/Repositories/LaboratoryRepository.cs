using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
    internal class LaboratoryRepository : ILaboratoryRepository
    {
        private readonly ISqlDataAcess sqlData;

        public LaboratoryRepository(ISqlDataAcess sqlData)
        {
            this.sqlData = sqlData;
        }

        public Task<IEnumerable<Laboratory>> GetAllAsync()
        {
            return sqlData.LoadData<Laboratory, dynamic>("", new { });
        }

        public async Task<Laboratory> GetByIdAsync(int id)
        {
            var data = await sqlData.LoadData<Laboratory, dynamic>("", new { id });
            return data.FirstOrDefault();
        }

        public async Task<Laboratory> GetByHostnameAsync(string hostname)
        {
            var data = await sqlData.LoadData<Laboratory, dynamic>("", new { hostname });
            return data.FirstOrDefault();
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
