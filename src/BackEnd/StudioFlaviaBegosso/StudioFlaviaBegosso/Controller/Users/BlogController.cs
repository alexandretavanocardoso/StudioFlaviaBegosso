using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.API.EndPoints.Users;

[Route("api/v1/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    [HttpGet("get-all")]
    public async Task<ActionResult<List<BlogDto>>> GetAllBlog()
        => await _blogService.GetAllBlogAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<BlogDto>> GetBlog(Guid id)
        => await _blogService.GetBlogAsync(id);

}
