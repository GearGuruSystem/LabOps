using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Tman.LabOps.WebUI.CrossCutting.IOC;
using Tman.LabOps.WebUI.Mud;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddServicesInjected(builder.Configuration);

await builder.Build().RunAsync();