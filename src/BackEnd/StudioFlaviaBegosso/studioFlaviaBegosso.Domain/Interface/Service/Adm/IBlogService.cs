using studioFlaviaBegosso.Domain.Dto;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IBlogService
{
    Task<List<BlogDto>> GetAllBlogAsync();
    Task<BlogDto> GetBlogAsync(Guid id);
    Task<bool> InsertBlogAsync(BlogDto blogRequet);
    Task<bool> UpdateBlogAsync(Guid id, BlogDto blogRequet);
    Task<bool> DeleteBlogAsync(Guid id);
}
