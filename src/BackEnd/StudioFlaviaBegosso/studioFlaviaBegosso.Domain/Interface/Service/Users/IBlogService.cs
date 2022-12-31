using studioFlaviaBegosso.Domain.Dto;

namespace studioFlaviaBegosso.Domain.Interface.Service.Users;

public interface IBlogService
{
    Task<List<BlogDto>> GetAllBlogAsync();
    Task<BlogDto> GetBlogAsync(Guid id);
}
