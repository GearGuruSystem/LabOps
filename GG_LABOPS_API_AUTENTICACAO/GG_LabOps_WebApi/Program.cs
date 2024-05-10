using GG_LabOps_Infra.InfrastructureModule;
using GG_LabOps_Services.ApplicationModule;
using GG_LabOps_WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.AddConfigurationBuilderApp();
app.MapControllers();
app.Run();