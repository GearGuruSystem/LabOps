using LabOps.Infra.Data.ControlApi;

namespace TMAN.LABOPS.FRONTEND
{
    public static class Configuration
    {
        public const string BaseAdressApi = WebConfiguration.BaseAdressApi;
        public const string FabricanteClient = WebConfiguration.HttpClient_Fabricante;
        public const string EquipamentoClient = WebConfiguration.HttpClient_Equipamento;
        public const string SituacaoClient = WebConfiguration.HttpClient_Situacao;
        public const string TipoEquipamentoClient = WebConfiguration.HttpClient_TipoEquipamento;
    }
}
