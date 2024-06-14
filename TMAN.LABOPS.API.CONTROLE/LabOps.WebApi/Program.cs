using LabOps.Infrastructure.CrossCutting.IOC;
using LabOps.WebApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.DependencyInjected(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();
app.UseCors(WebApiConfiguration.CorsPolicyName);
app.Run();