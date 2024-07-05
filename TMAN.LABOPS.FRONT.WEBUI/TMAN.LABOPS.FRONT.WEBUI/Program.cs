using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Tman.LabOps.WebUI;
using Tman.LabOps.WebUI.CrossCutting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddConfigurationServices();
builder.Services.AddHttpClientConfiguration();

await builder.Build().RunAsync();