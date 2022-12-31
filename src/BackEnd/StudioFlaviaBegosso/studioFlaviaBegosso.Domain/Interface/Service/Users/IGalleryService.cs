using studioFlaviaBegosso.Domain.Dto;

namespace studioFlaviaBegosso.Domain.Interface.Service.Users;
public interface IGalleryService
{
    Task<List<GalleryDto>> GetAllGalleryAsync();
    Task<GalleryDto> GetGalleryAsync(Guid id);
}
