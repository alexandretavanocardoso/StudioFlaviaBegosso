using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace studioFlaviaBegosso.Business.Services.Users;

public class GalleryService : IGalleryService
{
    private readonly IGalleryRepository _galleryRepository;
    public GalleryService(IGalleryRepository galleryRepository)
    {
        _galleryRepository = galleryRepository;
    }
}
