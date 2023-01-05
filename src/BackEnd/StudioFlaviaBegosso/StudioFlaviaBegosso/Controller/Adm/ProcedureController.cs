using studioFlaviaBegosso.Domain.Dto.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class ProcedureController : ControllerBase
{
    private readonly IProcedureService _procedureService;

    public ProcedureController(IProcedureService procedureService) {
        _procedureService = procedureService;
    }

    [HttpGet("get-procedure")]
    public async Task<ActionResult<List<ProcedureDto>>> GetAllProcedure() 
        => await _procedureService.GetAllProcedureAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<ProcedureDto>> GetProcedure(Guid id) 
        => await _procedureService.GetProcedureAsync(id);

    [HttpPost("insert-procedure")]
    public async Task<ActionResult<bool>> InsertProcedure([FromBody] ProcedureDto procedure) 
        => await _procedureService.InsertProcedureAsync(procedure);

    [HttpPut("update-procedure/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateProcedure(Guid id, [FromBody] ProcedureDto procedure) 
        => await _procedureService.UpdateProcedureAsync(id, procedure);

    [HttpDelete("delete-procedure/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteProcedure(Guid id) 
        => await _procedureService.DeleteProcedureAsync(id);
}
