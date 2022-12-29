using Microsoft.AspNetCore.Identity;
using StudioFlaviaBegosso.Configuration;
using StudioFlaviaBegosso.Extension;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.API.Configuration
{
    public static class ApiConfiguration
    {
        public static void AddDependenciesAPI(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddControllers();
            services.AddSqlServer<StudioFlaviaBegossoContext>(builder.Configuration["ConnectionString:StudioFlaviaBegossoDb"]);
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<StudioFlaviaBegossoContext>();

            services.AddToken(builder);
            services.AddSwagger();
            services.AddExtensionsServices();
            services.AddExtensionsRepositorys();
        }

        public static void AddApiConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
                app.UseSwaggerConfiguration();

            app.UseHttpsRedirection();

            app.UseToken();
        }
    }
}
