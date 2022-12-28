using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.API.EndPoints.Users;

[Route("api/user/[controller]")]
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
}
