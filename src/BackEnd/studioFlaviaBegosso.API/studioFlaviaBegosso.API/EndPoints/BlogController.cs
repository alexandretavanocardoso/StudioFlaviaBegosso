using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service;

namespace StudioFlaviaBegosso.API.EndPoints.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService) {
        _blogService = blogService;
    }

    [HttpGet("get-all-blog")]
    public IEnumerable<string> getAllBlog()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get-blog/{id:Guid}")]
    public string GetBlog(Guid id)
    {
        return "value";
    }

    [HttpPost("insert-blog")]
    public void InsertBlog([FromBody] string value)
    {
    }

    [HttpPut("update-blog/{id:Guid}")]
    public void UpdateBlog(Guid id, [FromBody] string value)
    {
    }

    [HttpDelete("delete-blog/{id:Guid}")]
    public void DeleteBlog(Guid id)
    {
    }
}
