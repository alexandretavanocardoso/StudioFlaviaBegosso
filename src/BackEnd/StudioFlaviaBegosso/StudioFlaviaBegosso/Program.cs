using StudioFlaviaBegosso.Configuration;
using StudioFlaviaBegosso.Extension;

var builder = WebApplication.CreateBuilder(args);
Environment.SetEnvironmentVariable("ASPNETCORE_APIURL", builder.Configuration.GetSection("Urls").GetSection("ApiUrl").Value);

builder.Services.AddDependenciesAPI(builder);
builder.Services.AddSwagger();
builder.Services.AddExtensionsServices();
builder.Services.AddExtensionsRepositorys();

var app = builder.Build();

app.UseApiConfiguration();

app.Run();
