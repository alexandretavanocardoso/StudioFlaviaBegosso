using studioFlaviaBegosso.Domain.Dto;
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
    public async Task<ActionResult<List<WorkDto>>> GetAllWork()
        => await _workService.GetAllWorkAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<WorkDto>> GetWork(Guid id)
        => await _workService.GetWorkAsync(id);

    [HttpPost("insert-work")]
    public async Task<ActionResult<bool>> InsertWork([FromBody] WorkDto work)
        => await _workService.InsertWorkAsync(work);

    [HttpPut("update-work/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateWork(Guid id, [FromBody] WorkDto work)
        => await _workService.UpdateWorkAsync(id, work);

    [HttpDelete("delete-work/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteWork(Guid id)
        => await _workService.DeleteWorkAsync(id);
}
