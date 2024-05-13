using Ocelot.DependencyInjection;
using OcelotApiGateway.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.ConfigureOcelotConfiguration();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.MapGet("/", async context => 
{
    await context.Response.WriteAsync("API GATEWAY FUNCIONANDO");
});

app.Run();