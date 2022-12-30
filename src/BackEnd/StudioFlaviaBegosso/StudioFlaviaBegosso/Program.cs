using StudioFlaviaBegosso.API.Configuration;
using StudioFlaviaBegosso.Configuration;
using StudioFlaviaBegosso.Extension;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependenciesAPI(builder);
builder.Services.AddSwagger();
builder.Services.AddExtensionsServices();
builder.Services.AddExtensionsRepositorys();

var app = builder.Build();

app.UseApiConfiguration();

app.Run();