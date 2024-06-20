using LabOps.Application.Interfaces;
using LabOps.Infra.Data.ControlApi.Services;
using LabOps.WebUI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services
    .AddHttpClient(Configuration.FabricanteClient, opt =>
    {
        opt.BaseAddress = new Uri(Configuration.BaseAdressApi);
    });
//.AddHttpMessageHandler(); PESQUISAR SOBRE PARA MANDAR INFORMAÇÕES GUARDADA NO HTTPCONTEXT A CADA REQUISIÇÃO
builder.Services.AddTransient<IServicesFabricante, ServiceFabricante>();
await builder.Build().RunAsync();
