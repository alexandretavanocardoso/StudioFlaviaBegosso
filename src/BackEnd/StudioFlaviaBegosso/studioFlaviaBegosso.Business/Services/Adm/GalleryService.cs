using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class GalleryService : IGalleryService
{
	private readonly IGalleryRepository _galleryRepository;
    public GalleryService(IGalleryRepository galleryRepository)
	{
        _galleryRepository = galleryRepository;
    }
}
