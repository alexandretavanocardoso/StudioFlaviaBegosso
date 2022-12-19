using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Domain.Interface.Service;

namespace StudioFlaviaBegosso.Business.Services;

public class BlogService : IBlogService
{
	private readonly IBlogRepository _blogRepository;

    public BlogService(IBlogRepository blogRepository)
	{
        _blogRepository = blogRepository;
    }
}
