using StudioFlaviaBegosso.Configuration;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.API.Configuration
{
    public static class ApiConfiguration
    {
        public static void AddDependenciesAPI(this IServiceCollection services, WebApplicationBuilder builder)
        {
            UseLogger(builder);

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

            FilterErrors(app);
        }

        private static void UseLogger(WebApplicationBuilder builder)
        {
            #pragma warning disable CS0618
            builder.WebHost.UseSerilog((context, configuration) => {
                configuration
                    .WriteTo.Console()
                    .WriteTo.MSSqlServer(
                        context.Configuration["ConnectionString:StudioFlaviaBegossoDb"],
                            sinkOptions: new MSSqlServerSinkOptions()
                            {
                                AutoCreateSqlTable = true,
                                TableName = "LogApi"
                            });
            });
            #pragma warning restore CS0618
        }

        private static void FilterErrors(WebApplication app)
        {
            app.UseExceptionHandler("/error");
            app.Map("/error", (HttpContext http) =>
            {
                var error = http.Features?.Get<IExceptionHandlerFeature>()?.Error;
                if (error != null)
                {
                    if (error is SqlException)
                        return Results.Problem(title: "Bando de dados esta fora!", statusCode: 500);
                }
                return Results.Problem(title: "Um erro aconteceu!", statusCode: 500);
            });
        }
    }
}
