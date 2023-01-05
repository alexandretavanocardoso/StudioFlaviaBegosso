using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.Users;

[Route("api/v1/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
public class GalleryController : ControllerBase
{
    private readonly IGalleryService _galleryService;

    public GalleryController(IGalleryService galleryService) {
        _galleryService = galleryService;
    }

    [HttpGet("get-all")]
    public async Task<ActionResult<List<GalleryDto>>> getAllGallery()
        => await _galleryService.GetAllGalleryAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<GalleryDto>> GetGallery(Guid id)
        => await _galleryService.GetGalleryAsync(id);
}
