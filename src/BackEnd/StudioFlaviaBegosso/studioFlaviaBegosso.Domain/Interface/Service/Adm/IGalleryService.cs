using studioFlaviaBegosso.Domain.Dto;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IGalleryService
{
    Task<List<GalleryDto>> GetAllGalleryAsync();
    Task<GalleryDto> GetGalleryAsync(Guid id);
    Task<bool> InsertGalleryAsync(GalleryDto galleryDto);
    Task<bool> UpdateGalleryAsync(Guid id, GalleryDto galleryDto);
    Task<bool> DeleteGalleryAsync(Guid id);
}
