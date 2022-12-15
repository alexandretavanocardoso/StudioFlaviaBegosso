using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Domain.Response;

namespace StudioFlaviaBegosso.Domain.Interface.Service;

public interface IBlogService
{
    //Task<IEnumerable<BlogModel>> GetAllBlogAsync();
    Task<BlogModel> GetBlogAsync(Guid id);
    Task<ResponseRequest> InsertBlogAsync(string value);
    Task<ResponseRequest> UpdateBlogAsync(Guid id, string value);
    Task<ResponseRequest> DeleteBlogAsync(Guid id);
}
