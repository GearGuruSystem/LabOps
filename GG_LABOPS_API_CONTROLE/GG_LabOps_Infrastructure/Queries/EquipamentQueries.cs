using GG_LabOps_Infrastructure.Queries.MapingData;

namespace GG_LabOps_Infrastructure.Queries
{
    internal static class EquipamentQueries
    {
        public static QueryModel GetAllEquipament()
        {
            var table = ContextMap.EquipamentTable();
            var query = $@"
                SELECT [Id]
                ,[LaboratoryId]
                ,[Inventory]
                ,[Hostname]
                ,[SerialNumber]
                ,[IsActive]
                ,[DateRegister]
                ,[BrandId]
                ,[TypeId]
                ,[ModelId]
                ,[LastUpdate]
                FROM {table}";
            var parameters = new { };
            return new QueryModel(query, parameters);
        }
    }
}
