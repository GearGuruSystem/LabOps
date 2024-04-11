using GG_LabOps_Infrastructure.Queries.MapingData;

namespace GG_LabOps_Infrastructure.Queries
{
    internal static class LaboratoryQueries
    {
        public static QueryModel GetAllLaboratory()
        {
            var table = ContextMap.LaboratoryTable();
            var query = $@"
                SELECT
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

        public static QueryModel GetLaboratoryById(int id)
        {
            var table = ContextMap.LaboratoryTable();
            var query = $@"
                DECLARE @Id INT
                SELECT [Id]
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
                FROM {table}
                WHERE [Id] = @Id";
            var parameters = new { Id = id };
            return new QueryModel(query, parameters);
        }

        public static QueryModel GetLaboratoryByHost(string hostname)
        {
            var table = ContextMap.LaboratoryTable();
            var query = $@"
                DECLARE @Hostname NVARCHAR
                SELECT [Id]
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
                FROM {table}
                WHERE [Hostname] = @Hostname";
            var parameters = new { Hostname = hostname };
            return new QueryModel(query, parameters);
        }

        public static QueryModel GetLaboratoryByInv(string inventory)
        {
            var table = ContextMap.LaboratoryTable();
            var query = $@"
                DECLARE @Inventory NVARCHAR
                SELECT [Id]
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
                FROM {table}
                WHERE [Inventory] = @Inventory";
            var parameters = new { Inventory = inventory };
            return new QueryModel(query, parameters);
        }
    }
}
