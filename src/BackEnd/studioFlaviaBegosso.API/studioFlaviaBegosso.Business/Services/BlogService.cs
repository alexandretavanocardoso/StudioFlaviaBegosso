using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Domain.Interface.Service;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Domain.Response;

namespace StudioFlaviaBegosso.Business.Services;

public class BlogService : IBlogService
{
	private readonly IBlogRepository _blogRepository;

    public BlogService(IBlogRepository blogRepository)
	{
        _blogRepository = blogRepository;
    }

    //public async Task<IEnumerable<BlogModel>> GetAllBlogAsync()
    //{
    //    yield return new BlogModel();
    //}

    public async Task<BlogModel> GetBlogAsync(Guid id)
    {
        return new BlogModel();
    }

    public async Task<ResponseRequest> InsertBlogAsync(string value)
    {
        return new ResponseRequest();
    }

    public async Task<ResponseRequest> UpdateBlogAsync(Guid id, string value)
    {
        return new ResponseRequest();
    }

    public async Task<ResponseRequest> DeleteBlogAsync(Guid id)
    {
        return new ResponseRequest();
    }
}
