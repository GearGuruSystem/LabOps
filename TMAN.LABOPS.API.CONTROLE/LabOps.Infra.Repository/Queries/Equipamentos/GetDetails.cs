namespace LabOps.Infra.Repository.Queries.Equipamentos
{
    internal class GetDetails
    {
        private readonly string Query = $@"
             SELECT 
                 e.Cl_IdEquipamento,
                 e.Cl_Nome,
                 e.Cl_IdSituacao,
                 s.Cl_Situacao AS Situacao,
                 e.Cl_IdTipoEquipamento,
                 te.Cl_Descricao AS TipoEquipamentoDescricao,
                 e.Cl_IdFabricante,
                 f.Cl_Nome AS FabricanteNome,
                 e.Cl_UsuarioInsercao,
                 e.Cl_AtualizadoEm,
                 ec.Cl_IdCaracteristicaValor,
                 ec.Cl_ValorIndividual
             FROM Tb_Equipamento e
             INNER JOIN Tb_Situacao s ON e.Cl_IdSituacao = s.Cl_Situacao
             INNER JOIN Tb_TipoEquipamento te ON e.Cl_IdTipoEquipamento = te.Cl_Descricao
             INNER JOIN Tb_Fabricante f ON e.Cl_IdFabricante = f.Cl_Nome
             INNER JOIN Tb_EquipamentoCaracteristica ec ON e.Cl_IdEquipamento = ec.Cl_IdCaracteristicaTipo";
    }
}
