using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class GalleryController : ControllerBase
{
    private readonly IGalleryService _galleryService;

    public GalleryController(IGalleryService galleryService) {
        _galleryService = galleryService;
    }

    [HttpGet("get-list")]
    public async Task<ActionResult<List<GalleryDto>>> getAllGallery()
        => await _galleryService.GetAllGalleryAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<GalleryDto>> GetGallery(Guid id)
        => await _galleryService.GetGalleryAsync(id);

    [HttpPost("insert-gallery")]
    public async Task<ActionResult<bool>> InsertGallery([FromBody] GalleryDto galleryDto)
        => await _galleryService.InsertGalleryAsync(galleryDto);

    [HttpPut("update-gallery/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateGallery(Guid id, [FromBody] GalleryDto galleryDto)
        => await _galleryService.UpdateGalleryAsync(id, galleryDto);

    [HttpDelete("delete-gallery/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteGallery(Guid id)
        => await _galleryService.DeleteGalleryAsync(id);
}
