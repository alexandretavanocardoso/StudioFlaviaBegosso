using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IBlogRepository
{
    Task<List<BlogModel>> GetAllBlog();
    Task<BlogModel> GetBlog(Guid id);
    Task<bool> InsertBlog(BlogModel blog);
    Task<bool> UpdateBlog(Guid id, BlogModel blog);
    Task<bool> DeleteBlog(Guid id);
}
