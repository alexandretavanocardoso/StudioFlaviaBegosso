using StudioFlaviaBegosso.API.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependenciesAPI(builder);

builder.Services.AddDependenciesServices();
builder.Services.AddDependenciesRepositorys();

builder.Services.AddDependenciesSwagger();

var app = builder.Build();

app.AddApiConfiguration();