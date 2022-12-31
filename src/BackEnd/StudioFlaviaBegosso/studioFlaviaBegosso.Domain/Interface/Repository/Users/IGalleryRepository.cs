using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Users;
public interface IGalleryRepository
{
    Task<List<GalleryModel>> GetAllGallery();
    Task<GalleryModel> GetGallery(Guid id);
}
