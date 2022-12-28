using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

[Route("api/adm/[controller]")]
[Authorize]
[ApiController]
public class GalleryController : ControllerBase
{
    private readonly IGalleryService _galleryService;

    public GalleryController(IGalleryService galleryService) {
        _galleryService = galleryService;
    }

    [HttpGet("get-list")]
    public IEnumerable<string> getAllGallery()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get/{id:Guid}")]
    public string GetGallery(Guid id)
    {
        return "value";
    }

    [HttpPost("insert-gallery")]
    public void InsertGallery([FromBody] string value)
    {
    }

    [HttpPut("update-gallery/{id:Guid}")]
    public void UpdateGallery(Guid id, [FromBody] string value)
    {
    }

    [HttpDelete("delete-gallery/{id:Guid}")]
    public void DeleteGallery(Guid id)
    {
    }
}
