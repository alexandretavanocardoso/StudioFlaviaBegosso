using Microsoft.AspNetCore.Identity;
using StudioFlaviaBegosso.Configuration;
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
            services.AddAutoMapper(typeof(AutoMapperConfiguration).Assembly);
        }

        public static void UseApiConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("../swagger/v1/swagger.json", "Studio Flavia Begosso v1");
                });
            }

            app.MapControllers();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
