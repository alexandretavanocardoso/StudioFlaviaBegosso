using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.API.EndPoints.Users;

[Route("api/user/[controller]")]
[ApiController]
public class GalleryController : ControllerBase
{
    private readonly IGalleryService _galleryService;

    public GalleryController(IGalleryService galleryService) {
        _galleryService = galleryService;
    }

    [HttpGet("get-all-gallery")]
    public IEnumerable<string> getAllGallery()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get-gallery/{id:Guid}")]
    public string GetGallery(Guid id)
    {
        return "value";
    }
}
