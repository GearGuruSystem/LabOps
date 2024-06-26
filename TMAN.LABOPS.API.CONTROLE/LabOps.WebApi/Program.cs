using LabOps.Infra.CrossCutting.IOC;
using LabOps.WebApi;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConfigurationLogger();
builder.Services.DependencyInjected(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigurationCorsPolicy();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    Log.Logger.Debug($"Iniciando WebApi -> {DateTime.Now.Date}");
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();
app.UseCors(WebApiConfiguration.CorsPolicyName);
app.Run();
