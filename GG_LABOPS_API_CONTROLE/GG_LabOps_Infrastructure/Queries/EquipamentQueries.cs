using GG_LabOps_Infrastructure.Queries.MapingData;

namespace GG_LabOps_Infrastructure.Queries
{
    internal static class EquipamentQueries
    {
        public static QueryModel GetAllEquipament()
        {
            var table = ContextMap.EquipamentTable();
            var query = $@"
                SELECT equip.[id_equip] AS [Id],
                    equip.[inventario] AS [Inventory],
                    equip.[hostname] AS [Hostname],
                    equip.[numeroSerie] AS [SerialNumber],
                    marcEquip.[nomeMarca] AS [BrandName],
                    modelEquip.[nomeModelo] AS [ModelName],
                    tipoEquip.[nomeTipo] AS [TypeName],
                    equip.[ativa] AS [IsActive],
                    equip.[dataRegistro] AS [DateRegister],
                    equip.[ultimaAtualizacao] AS [LastUpdate]
                FROM {table} AS equip
	                INNER JOIN [dbo].[TB_MarcaEquipamento] AS marcEquip
	                ON equip.[id_equip] = marcEquip.[id_marca]
	                INNER JOIN [dbo].[TB_ModeloEquipamento] AS modelEquip
	                ON equip.[id_equip] = modelEquip.[id_modelo]
	                INNER JOIN [dbo].TB_TipoEquipamento AS tipoEquip 
	                ON equip.[id_equip] = tipoEquip.[id_tipo];";
            var parameters = new { };
            return new QueryModel(query, parameters);
        }

        public static QueryModel GetEquipamentById(int id)
        {
            var table = ContextMap.EquipamentTable();
            var query = $@"
                SELECT equip.[id_equip] AS [Id],
                    equip.[inventario] AS [Inventory],
                    equip.[hostname] AS [Hostname],
                    equip.[numeroSerie] AS [SerialNumber],
                    marcEquip.[nomeMarca] AS [BrandName],
                    modelEquip.[nomeModelo] AS [ModelName],
                    tipoEquip.[nomeTipo] AS [TypeName],
                    equip.[ativa] AS [IsActive],
                    equip.[dataRegistro] AS [DateRegister],
                    equip.[ultimaAtualizacao] AS [LastUpdate]
                FROM {table} AS equip
	                INNER JOIN [dbo].[TB_MarcaEquipamento] AS marcEquip
	                ON equip.[id_equip] = marcEquip.[id_marca]
	                INNER JOIN [dbo].[TB_ModeloEquipamento] AS modelEquip
	                ON equip.[id_equip] = modelEquip.[id_modelo]
	                INNER JOIN [dbo].TB_TipoEquipamento AS tipoEquip 
	                ON equip.[id_equip] = tipoEquip.[id_tipo]
                WHERE [id_equip] = @idParam";
            var parameters = new { @idParam = id };
            return new QueryModel(query, parameters);
        }
    }
}
