using App;
using FastEndpoints;
using Infra;

var bld = WebApplication.CreateBuilder(args);

bld.Services.AddFastEndpoints();

// Register services from each layer
bld.Services.AddApplicationServices();
bld.Services.AddInfrastructureServices(bld.Configuration);

var app = bld.Build();
app.UseFastEndpoints();
app.Run();
