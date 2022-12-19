using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Domain.Interface.Service;

namespace StudioFlaviaBegosso.Business.Services;

public class GalleryService : IGalleryService
{
	private readonly IGalleryRepository _galleryRepository;
    public GalleryService(IGalleryRepository galleryRepository)
	{
        _galleryRepository = galleryRepository;
    }
}
