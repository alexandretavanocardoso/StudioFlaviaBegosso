using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service;

namespace StudioFlaviaBegosso.API.EndPoints.Blog;

[Route("api/[controller]")]
[ApiController]
public class WorkController : ControllerBase
{
    private readonly IWorkService _workService;

    public WorkController(IWorkService workService) {
        _workService = workService;
    }

    [HttpGet("get-all-work")]
    public IEnumerable<string> getAllWork()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get-work/{id:Guid}")]
    public string GetWork(Guid id)
    {
        return "value";
    }

    [HttpPost("insert-work")]
    public void InsertWork([FromBody] string value)
    {
    }

    [HttpPut("update-work/{id:Guid}")]
    public void UpdateWork(Guid id, [FromBody] string value)
    {
    }

    [HttpDelete("delete-work/{id:Guid}")]
    public void DeleteWork(Guid id)
    {
    }
}
