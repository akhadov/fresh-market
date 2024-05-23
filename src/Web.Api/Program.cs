using Application;
using Infrastructure;
using Serilog;
using Web.Api;
using Web.Api.Endpoints;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, loggerConfig) =>
    loggerConfig.ReadFrom.Configuration(context.Configuration));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddWebApi(builder.Configuration);

builder.Services.AddHttpContextAccessor();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.UseRequestContextLogging();

app.UseSerilogRequestLogging();

app.UseExceptionHandler();

app.MapCategoryEndpoints();
app.MapProductEndpoints();
app.MapOrderEndpoints();
app.MapCustomerEndpoints();
app.UseHttpsRedirection();

//app.UseAuthorization();


app.Run();

public partial class Program { }
