using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class WorkController : ControllerBase
{
    private readonly IWorkService _workService;

    public WorkController(IWorkService workService) {
        _workService = workService;
    }

    [HttpGet("get-list")]
    public IEnumerable<string> getAllWork()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("get/{id:Guid}")]
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
