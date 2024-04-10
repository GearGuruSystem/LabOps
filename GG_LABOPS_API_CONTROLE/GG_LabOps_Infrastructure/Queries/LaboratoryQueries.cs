using GG_LabOps_Infrastructure.Queries.MapingData;

namespace GG_LabOps_Infrastructure.Queries
{
    internal static class LaboratoryQueries
    {
        public static QueryModel GetAllLaboratory()
        {
            var table = ContextMap.LaboratoryTable();
            var query = $@"
                SELECT TOP (1000) 
                ,[Id]
                ,[Inventory]
                ,[Hostname]
                ,[BrandEquipamentId]
                ,[SerieNumber]
                ,[EquipamentType]
                ,[EquipamentModel]
                ,[Owner]
                ,[IdOwner]
                ,[Observation]
                ,[IsActive]
                ,[DateRegister]
                ,[LastUpdate]
                FROM {table}";
            var parameters = new { };
            return new QueryModel(query, parameters);
        }
    }
}
