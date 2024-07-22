using AutoMapper;
using LabOps.Infra.Data.CrossCutting;
using LabOps.WebUI.Helpers.Mapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddServicesInjected(builder.Configuration);
#region Configuration AutoMapper
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapEquipamentos());
    mc.AddProfile(new MapFabricantes());
    //mc.AddProfile(new MapLaboratorio());
    //mc.AddProfile(new MapSituacao());
    //mc.AddProfile(new MapTipoEquipamento());
    mc.AddProfile(new MapUsuarios());
});
var mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion Configuration AutoMapper

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
