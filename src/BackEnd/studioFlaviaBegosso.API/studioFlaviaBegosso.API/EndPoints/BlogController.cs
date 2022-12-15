using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Domain.Response;

namespace StudioFlaviaBegosso.API.EndPoints.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService) {
        _blogService = blogService;
    }

    //[HttpGet("get-all-blog")]
    //public async Task<ActionResult<IEnumerable<BlogModel>>> getAllBlog() => await _blogService.GetAllBlogAsync();

    [HttpGet("get-blog/{id:Guid}")]
    public async Task<ActionResult<BlogModel>> GetBlog(Guid id) => await _blogService.GetBlogAsync(id);

    [HttpPost("insert-blog")]
    public async Task<ActionResult<ResponseRequest>> InsertBlog([FromBody] string value) => await _blogService.InsertBlogAsync(value);

    [HttpPut("update-blog/{id:Guid}")]
    public async Task<ActionResult<ResponseRequest>> UpdateBlog(Guid id, [FromBody] string value) => await _blogService.UpdateBlogAsync(id, value);

    [HttpDelete("delete-blog/{id:Guid}")]
    public async Task<ActionResult<ResponseRequest>> DeleteBlog(Guid id) => await _blogService.DeleteBlogAsync(id);
}
