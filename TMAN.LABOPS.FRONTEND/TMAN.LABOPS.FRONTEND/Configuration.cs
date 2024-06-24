using LabOps.Infra.Data.ControlApi;

namespace LabOps.WebUI
{
    public static class Configuration
    {
        public const string BaseAdressApi = EndpointsConfiguration.BaseAdressApi;
        public const string FabricanteClient = EndpointsConfiguration.HttpClient_Fabricante;
        public const string EquipamentoClient = EndpointsConfiguration.HttpClient_Equipamento;
        public const string SituacaoClient = EndpointsConfiguration.HttpClient_Situacao;
        public const string TipoEquipamentoClient = EndpointsConfiguration.HttpClient_TipoEquipamento;
    }
}
