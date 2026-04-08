using Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddApiServices(builder.Configuration)
        .AddInfrastructureServices(builder.Configuration)
        .AddApplicatonServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    await app.InitializeDataBaseAsync();
}

app.UseApiServices();

app.Run();
