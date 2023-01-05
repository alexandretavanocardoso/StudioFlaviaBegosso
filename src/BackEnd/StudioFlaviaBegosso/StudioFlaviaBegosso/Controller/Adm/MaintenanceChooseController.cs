using studioFlaviaBegosso.Domain.Dto.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class MaintenanceChooseController : ControllerBase
{
    private readonly IMaintenanceChooseService _maintenanceChooseService;

    public MaintenanceChooseController(IMaintenanceChooseService maintenanceChooseService) {
        _maintenanceChooseService = maintenanceChooseService;
    }

    [HttpGet("get-all-maintenance-choose")]
    public async Task<ActionResult<List<MaintenanceChooseDto>>> GetAllMaintenanceChoose()
       => await _maintenanceChooseService.GetAllMaintenanceChooseAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<MaintenanceChooseDto>> GetMaintenanceChoose(Guid id)
        => await _maintenanceChooseService.GetMaintenanceChooseAsync(id);

    [HttpPost("insert-maintenance-choose")]
    public async Task<ActionResult<bool>> InsertMaintenanceChoose([FromBody] MaintenanceChooseDto maintenanceChoose)
       => await _maintenanceChooseService.InsertMaintenanceChooseAsync(maintenanceChoose);

    [HttpPut("update-maintenance-choose/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateMaintenanceChoose(Guid id, [FromBody] MaintenanceChooseDto maintenanceChoose)
        => await _maintenanceChooseService.UpdateMaintenanceChooseAsync(id, maintenanceChoose);

    [HttpDelete("delete-maintenance-choose/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteMaintenanceChoose(Guid id)
        => await _maintenanceChooseService.DeleteMaintenanceChooseAsync(id);
}
