using Microsoft.Extensions.DependencyInjection;

namespace LabOps.Infra.CrossCutting.IOC
{
    public static class WebApiConfiguration
    {
        public static string CorsPolicyName = "wasm";
        public static string FrontEnd = "";
        public static string ServiceNotification = "";
    }
}
