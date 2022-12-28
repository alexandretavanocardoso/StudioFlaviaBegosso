using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class BlogService : IBlogService
{
	private readonly IBlogRepository _blogRepository;

    public BlogService(IBlogRepository blogRepository)
	{
        _blogRepository = blogRepository;
    }
}
