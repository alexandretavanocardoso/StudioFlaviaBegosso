using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

[ApiController]
[Route("api/adm/[controller]")]
[Authorize(Policy = "AdminPolicy")]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService) {
        _blogService = blogService;
    }

    [HttpGet("get-list")]
    public IEnumerable<string> getAllBlog()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get/{id:Guid}")]
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
