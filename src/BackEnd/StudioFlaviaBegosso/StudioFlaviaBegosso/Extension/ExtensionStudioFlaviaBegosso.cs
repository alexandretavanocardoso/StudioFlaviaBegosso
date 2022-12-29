using studioFlaviaBegosso.Business.Services.Users;
using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;
using studioFlaviaBegosso.Infra.Data.Repositorys.Users;
using StudioFlaviaBegosso.Business.Services.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

namespace StudioFlaviaBegosso.Extension
{
    public static class ExtensionStudioFlaviaBegosso
    {
        public static void AddExtensionsServices(this IServiceCollection services)
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

        public static void AddExtensionsRepositorys(this IServiceCollection services)
        {
            #region[Adm]
            services.AddScoped<Domain.Interface.Repository.Adm.IBlogRepository, Infra.Data.Repositorys.Adm.BlogRepository>();
            services.AddScoped<Domain.Interface.Repository.Adm.IGalleryRepository, Infra.Data.Repositorys.Adm.GalleryRepository>();
            services.AddScoped<Domain.Interface.Repository.Adm.IQuestionFrequentRepository, Infra.Data.Repositorys.Adm.QuestionFrequentRepository>();
            services.AddScoped<Domain.Interface.Repository.Adm.IWorkRepository, Infra.Data.Repositorys.Adm.WorkRepository>();
            #endregion[Adm]

            #region[Users]
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IGalleryRepository, GalleryRepository>();
            services.AddScoped<IQuestionFrequentRepository, QuestionFrequentRepository>();
            services.AddScoped<IWorkRepository, WorkRepository>();
            #endregion[Users]
        }
    }
}
