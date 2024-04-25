using GG_LabOps_Infrastructure.Queries.MapingData;

namespace GG_LabOps_Infrastructure.Queries
{
    internal static class EquipamentQueries
    {
        internal static QueryModel GetAllEquipament()
        {
            var query = $@"
                SELECT equip.[id_equip] AS [Id]
                      ,equip.[inventario]
                      ,equip.[hostname]
                      ,equip.[numeroSerie]
                      ,marcEquip.[nomeMarca] AS MarcaNome
                      ,modeEquip.[nomeModelo] AS ModeloNome
                      ,tipoEquip.[nomeTipo] AS TipoNome
                      ,equip.[ativa] 
                      ,equip.[dataRegistro]
                      ,equip.[ultimaAtualizacao]
                  FROM [dbo].[TB_Equipamento] AS equip
                  INNER JOIN [dbo].[TB_MarcaEquipamento] AS marcEquip ON equip.[id_marca] = marcEquip.id_marca
                  INNER JOIN [dbo].[TB_TipoEquipamento] AS tipoEquip ON equip.[id_tipo] = tipoEquip.id_tipo
                  INNER JOIN [dbo].[TB_ModeloEquipamento] AS modeEquip ON equip.[id_modelo] = modeEquip.id_modelo";
            var parameters = new { };
            return new QueryModel(query, parameters);
        }

        internal static QueryModel GetEquipamentById(int id)
        {
            var query = $@"
                SELECT equip.[id_equip] AS [Id]
                      ,equip.[inventario]
                      ,equip.[hostname]
                      ,equip.[numeroSerie]
                      ,marcEquip.[nomeMarca] AS MarcaNome
                      ,modeEquip.[nomeModelo] AS ModeloNome
                      ,tipoEquip.[nomeTipo] AS TipoNome
                      ,equip.[ativa] 
                      ,equip.[dataRegistro]
                      ,equip.[ultimaAtualizacao]
                  FROM [dbo].[TB_Equipamento] AS equip
                  INNER JOIN [dbo].[TB_MarcaEquipamento] AS marcEquip ON equip.[id_marca] = marcEquip.id_marca
                  INNER JOIN [dbo].[TB_TipoEquipamento] AS tipoEquip ON equip.[id_tipo] = tipoEquip.id_tipo
                  INNER JOIN [dbo].[TB_ModeloEquipamento] AS modeEquip ON equip.[id_modelo] = modeEquip.id_modelo
                  WHERE [id_equip] = @idParam";
            var parameters = new { @idParam = id };
            return new QueryModel(query, parameters);
        }
    }
}
