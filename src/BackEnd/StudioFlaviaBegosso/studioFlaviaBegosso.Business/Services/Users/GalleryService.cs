using AutoMapper;
using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;
using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Business.Services.Users;

public class GalleryService : IGalleryService
{
    private readonly IGalleryRepository _galleryRepository;
    private readonly IMapper _mapper;

    public GalleryService(IGalleryRepository galleryRepository, IMapper mapper)
    {
        _galleryRepository = galleryRepository;
        _mapper = mapper;
    }

    public async Task<List<GalleryDto>> GetAllGalleryAsync()
    {
        List<GalleryModel> model = await _galleryRepository.GetAllGallery();
        return _mapper.Map<List<GalleryDto>>(model);
    }

    public async Task<GalleryDto> GetGalleryAsync(Guid id)
    {
        GalleryModel model = await _galleryRepository.GetGallery(id);
        return _mapper.Map<GalleryDto>(model);
    }
}
