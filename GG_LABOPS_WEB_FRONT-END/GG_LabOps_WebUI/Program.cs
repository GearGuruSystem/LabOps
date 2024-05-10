using GG_LabOps_Application.ApplicationModule;
using GG_LabOps_Infra.InfrastructureModule;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration);

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");
app.Run();
