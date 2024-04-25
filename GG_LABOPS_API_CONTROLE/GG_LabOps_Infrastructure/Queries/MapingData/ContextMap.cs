namespace GG_LabOps_Infrastructure.Queries.MapingData
{
    internal static class ContextMap
    {
        internal static string LaboratoryTable() => "[dbo].[TB_Laboratorio]";
        internal static string EquipamentTable() => "[dbo].[TB_Equipamento]";
        internal static string BrandTable() => "[dbo].[TB_MarcaEquipamento]";
        internal static string ModelEquipamentTable() => "[dbo].[TB_ModeloEquipamento]";
        internal static string TypeEquipamentTable() => "[dbo].[TB_TipoEquipamento]";
    }
}
