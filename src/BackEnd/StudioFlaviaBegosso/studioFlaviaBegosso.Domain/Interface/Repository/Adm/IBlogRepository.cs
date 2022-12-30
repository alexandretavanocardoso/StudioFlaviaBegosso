using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IBlogRepository
{
    Task<List<BlogModel>> GetAllBlogAsync();
    Task<BlogModel> GetBlogAsync(Guid id);
    Task<bool> InsertBlogAsync(BlogModel blog);
    Task<bool> UpdateBlogAsync(Guid id, BlogModel blog);
    Task<bool> DeleteBlogAsync(Guid id);
}
