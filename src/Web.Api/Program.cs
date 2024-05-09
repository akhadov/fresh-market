using Application;
using Infrastructure;
using Web.Api;
using Web.Api.Endpoints;
using Web.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddWebApi(builder.Configuration);

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.ApplyMigrations();
}

app.MapCategoryEndpoints();
app.UseHttpsRedirection();

//app.UseAuthorization();


app.Run();

public partial class Program { }
