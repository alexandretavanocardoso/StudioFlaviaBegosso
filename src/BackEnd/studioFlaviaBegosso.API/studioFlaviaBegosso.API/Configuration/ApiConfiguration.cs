using Microsoft.AspNetCore.Cors.Infrastructure;
using StudioFlaviaBegosso.Business.Services;
using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Domain.Interface.Service;
using StudioFlaviaBegosso.Infra.Data.Context;
using StudioFlaviaBegosso.Infra.Data.Repositorys;

namespace StudioFlaviaBegosso.API.Configuration
{
    public static class ApiConfiguration
    {
        public static void AddDependenciesAPI(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<StudioFlaviaBegossoContext>();
            //services.AddSqlServer<StudioFlaviaBegossoContext>(builder.Configuration["ConnectionString:StudioFlaviaBegossoDb"]);
        }

        public static void AddDependenciesSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public static void AddDependenciesServices(this IServiceCollection services)
        {
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IGalleryService, GalleryService>();
            services.AddScoped<IWorkService, WorkService>();
            services.AddScoped<IQuestionFrequentService, QuestionFrequentService>();
        }

        public static void AddDependenciesRepositorys(this IServiceCollection services)
        {
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IGalleryRepository, GalleryRepository>();
            services.AddScoped<IWorkRepository, WorkRepository>();
            services.AddScoped<IQuestionFrequentRepository, QuestionFrequentRepository>();
        }

        public static void AddApiConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.Run();
        }
    }
}
