using StudioFlaviaBegosso.API.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependenciesAPI(builder);
builder.Services.AddDependenciesSwagger();
builder.Services.AddDependenciesServices();
builder.Services.AddDependenciesRepositorys();

var app = builder.Build();

app.AddApiConfiguration();

app.Run();