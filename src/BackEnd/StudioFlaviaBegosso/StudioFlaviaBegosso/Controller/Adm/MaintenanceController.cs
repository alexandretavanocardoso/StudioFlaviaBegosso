using studioFlaviaBegosso.Domain.Dto.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class MaintenanceController : ControllerBase
{
    private readonly IMaintenanceService _maintenanceService;

    public MaintenanceController(IMaintenanceService maintenanceService) {
        _maintenanceService = maintenanceService;
    }

    [HttpGet("get-all-maintenance")]
    public async Task<ActionResult<List<MaintenanceDto>>> GetAllMaintenance() 
        => await _maintenanceService.GetAllMaintenanceAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<MaintenanceDto>> GetMaintenance(Guid id) 
        => await _maintenanceService.GetMaintenanceAsync(id);

    [HttpPost("insert-maintenance")]
    public async Task<ActionResult<bool>> InsertMaintenance([FromBody] MaintenanceDto maintenance) 
        => await _maintenanceService.InsertMaintenanceAsync(maintenance);

    [HttpPut("update-maintenance/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateMaintenance(Guid id, [FromBody] MaintenanceDto maintenance) 
        => await _maintenanceService.UpdateMaintenanceAsync(id, maintenance);

    [HttpDelete("delete-maintenance/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteMaintenance(Guid id) 
        => await _maintenanceService.DeleteMaintenanceAsync(id);
}
