using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IGalleryRepository
{
    Task<List<GalleryModel>> GetAllGallery();
    Task<GalleryModel> GetGallery(Guid id);
    Task<bool> InsertGallery(GalleryModel gallery);
    Task<bool> UpdateGallery(Guid id, GalleryModel gallery);
    Task<bool> DeleteGallery(Guid id);
}
