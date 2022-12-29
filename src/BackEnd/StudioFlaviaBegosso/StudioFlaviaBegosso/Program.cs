using StudioFlaviaBegosso.API.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependenciesAPI(builder);

var app = builder.Build();

app.AddApiConfiguration();

app.Run();