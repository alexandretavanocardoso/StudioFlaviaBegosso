using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;
using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Business.Services.Adm;

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

    public async Task<bool> InsertGalleryAsync(GalleryDto galleryDto)
    {
        galleryDto.Image = ConvertStringToArrayByte(galleryDto);
        GalleryModel model = _mapper.Map<GalleryModel>(galleryDto);
        return await _galleryRepository.InsertGallery(model);
    }

    public async Task<bool> UpdateGalleryAsync(Guid id, GalleryDto galleryDto)
    {
        galleryDto.Image = ConvertStringToArrayByte(galleryDto);
        GalleryModel model = _mapper.Map<GalleryModel>(galleryDto);
        return await _galleryRepository.UpdateGallery(id, model);
    }

    public async Task<bool> DeleteGalleryAsync(Guid id)
        => await _galleryRepository.DeleteGallery(id);

    #region[Privados]
    private byte[] ConvertStringToArrayByte(GalleryDto galleryDto)
    {
        Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
        string image = regex.Replace(galleryDto.ImageString, string.Empty);
        galleryDto.Image = Convert.FromBase64String(image);

        return galleryDto.Image;
    }
    #endregion[Privados]
}
