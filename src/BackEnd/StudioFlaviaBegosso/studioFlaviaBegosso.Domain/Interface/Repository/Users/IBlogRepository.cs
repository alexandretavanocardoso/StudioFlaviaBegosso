using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Users;
public interface IBlogRepository
{
    Task<List<BlogModel>> GetAllBlogAsync();
    Task<BlogModel> GetBlogAsync(Guid id);
}
