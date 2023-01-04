using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService) {
        _blogService = blogService;
    }

    [HttpGet("get-list")]
    public async Task<ActionResult<List<BlogDto>>> GetAllBlog() 
        => await _blogService.GetAllBlogAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<BlogDto>> GetBlog(Guid id) 
        => await _blogService.GetBlogAsync(id);

    [HttpPost("insert-blog")]
    public async Task<ActionResult<bool>> InsertBlog([FromBody] BlogDto blogRequet) 
        => await _blogService.InsertBlogAsync(blogRequet);

    [HttpPut("update-blog/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateBlog(Guid id, [FromBody] BlogDto blogRequet) 
        => await _blogService.UpdateBlogAsync(id, blogRequet);

    [HttpDelete("delete-blog/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteBlog(Guid id) 
        => await _blogService.DeleteBlogAsync(id);
}
