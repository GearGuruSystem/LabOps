using Auth.LabOps.Infrastructure.CrossCutting.IOC;

var builder = WebApplication.CreateBuilder(args);
builder.Services.DependencyInjected(builder.Configuration);
builder.Services.AddJwtConfiguration(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseJwtConfiguration();
app.MapControllers();
app.Run();