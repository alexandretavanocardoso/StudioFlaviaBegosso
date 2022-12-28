using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using studioFlaviaBegosso.Business.Services.Users;
using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;
using studioFlaviaBegosso.Infra.Data.Repositorys.Users;
using StudioFlaviaBegosso.Business.Services.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;
using StudioFlaviaBegosso.Infra.Data.Context;
using System.Text;

namespace StudioFlaviaBegosso.API.Configuration
{
    public static class ApiConfiguration
    {
        public static void AddDependenciesAPI(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddSqlServer<StudioFlaviaBegossoContext>(builder.Configuration["ConnectionString:StudioFlaviaBegossoDb"]);
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<StudioFlaviaBegossoContext>();

            services.AddAuthorization();
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateActor = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["JwtBearerToken:Issuer"],
                    ValidAudience = builder.Configuration["JwtBearerToken:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtBearerToken:SecretKey"]))
                };
            });
        }

        public static void AddDependenciesSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Studio Flavia Begosso",
                    Version = "v1"
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Cabeçalho da Autorização JWT. \r\n\r\n Enter 'Bearer' [space] token \r\n\r\n Exemplo: \"Bearer seuToken\"",
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement 
                {
                    {
                        new OpenApiSecurityScheme {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });
        }

        public static void AddDependenciesServices(this IServiceCollection services)
        {
            #region[Adm]
            services.AddScoped<Domain.Interface.Service.Adm.IBlogService, Business.Services.Adm.BlogService>();
            services.AddScoped<Domain.Interface.Service.Adm.IGalleryService, Business.Services.Adm.GalleryService>();
            services.AddScoped<Domain.Interface.Service.Adm.IQuestionFrequentService, Business.Services.Adm.QuestionFrequentService>();
            services.AddScoped<Domain.Interface.Service.Adm.IWorkService, Business.Services.Adm.WorkService>();
            #endregion[Adm]

            #region[Authentication]
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ITokenService, TokenService>();
            #endregion[Authentication]

            #region[Users]
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IGalleryService, GalleryService>();
            services.AddScoped<IQuestionFrequentService, QuestionFrequentService>();
            services.AddScoped<IWorkService, WorkService>();
            #endregion[Users]
        }

        public static void AddDependenciesRepositorys(this IServiceCollection services)
        {
            #region[Adm]
            services.AddScoped<Domain.Interface.Repository.Adm.IBlogRepository,  Infra.Data.Repositorys.Adm.BlogRepository>();
            services.AddScoped<Domain.Interface.Repository.Adm.IGalleryRepository,  Infra.Data.Repositorys.Adm.GalleryRepository>();
            services.AddScoped<Domain.Interface.Repository.Adm.IQuestionFrequentRepository,  Infra.Data.Repositorys.Adm.QuestionFrequentRepository>();
            services.AddScoped<Domain.Interface.Repository.Adm.IWorkRepository,  Infra.Data.Repositorys.Adm.WorkRepository>();
            #endregion[Adm]

            #region[Users]
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IGalleryRepository, GalleryRepository>();
            services.AddScoped<IQuestionFrequentRepository, QuestionFrequentRepository>();
            services.AddScoped<IWorkRepository, WorkRepository>();
            #endregion[Users]
        }

        public static void AddApiConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
