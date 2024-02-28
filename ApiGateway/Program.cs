using ApiGateway.Extentsions;
using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDiscoveryClient();
builder.Services.AddReverseProxy()
    .LoadFromEureka(builder.Services);

var app = builder.Build();
app.MapGet("/", t => t.Response.WriteAsync("Hello From Api GateWay"));
app.MapReverseProxy();

app.Run();
