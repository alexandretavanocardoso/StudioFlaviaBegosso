using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace StudioFlaviaBegosso.API.EndPoints.Users;

[Route("api/v1/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
public class WorkController : ControllerBase
{
    private readonly IWorkService _workService;

    public WorkController(IWorkService workService) {
        _workService = workService;
    }

    [HttpGet("get-all")]
    public async Task<ActionResult<List<WorkDto>>> GetAllWork()
        => await _workService.GetAllWorkAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<WorkDto>> GetWork(Guid id)
        => await _workService.GetWorkAsync(id);
}
