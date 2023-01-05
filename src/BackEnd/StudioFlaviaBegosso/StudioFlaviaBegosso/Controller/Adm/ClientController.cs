using studioFlaviaBegosso.Domain.Dto.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Adm;

[Route("api/v1/adm/[controller]")]
[ApiExplorerSettings(IgnoreApi = false)]
[ApiController]
[Authorize(Policy = "AdminPolicy")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService) {
        _clientService = clientService;
    }

    #region[Client]
    [HttpGet("get-client")]
    public async Task<ActionResult<List<ClientDto>>> GetAllClient() 
        => await _clientService.GetAllClientAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<ClientDto>> GetClient(Guid id) 
        => await _clientService.GetClientAsync(id);

    [HttpPost("insert-client")]
    public async Task<ActionResult<bool>> InsertClient([FromBody] ClientDto client) 
        => await _clientService.InsertClientAsync(client);

    [HttpPut("update-client/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateClient(Guid id, [FromBody] ClientDto client)
    => await _clientService.UpdateClientAsync(id, client);

    [HttpDelete("delete-client/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteClient(Guid id) 
        => await _clientService.DeleteClientAsync(id);
    #endregion[Client]

    #region[Schedule]
    [HttpGet("get-schedule-client")]
    public async Task<ActionResult<List<ScheduleClientDto>>> GetAllScheduleClient()
        => await _clientService.GetAllScheduleClientAsync();

    [HttpGet("get-schedule-client/{id:Guid}")]
    public async Task<ActionResult<ScheduleClientDto>> GetScheduleClient(Guid id)
        => await _clientService.GetScheduleClientAsync(id);

    [HttpPut("mark-schedule-update")]
    public async Task<ActionResult<bool>> MarkScheduleUpdate(Guid id, [FromBody] ScheduleClientDto schedule)
    => await _clientService.MarkScheduleUpdateAsync(id, schedule);

    [HttpPost("mark-schedule-insert")]
    public async Task<ActionResult<bool>> MarkScheduleInsert([FromBody] ScheduleClientDto schedule)
    => await _clientService.MarkScheduleInsertAsync(schedule);

    [HttpDelete("delete-schedule-client/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteScheduleClient(Guid id)
    => await _clientService.DeleteScheduleClientAsync(id);
    #endregion[Schedule]

    #region[Schedule History]
    [HttpGet("get-schedule-history-client")]
    public async Task<ActionResult<List<ScheduleClientHistoryDto>>> GetAllScheduleHistoryClient()
        => await _clientService.GetAllScheduleHistoryClientAsync();

    [HttpDelete("delete-schedule-history-client/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteScheduleHistoryClient(Guid id)
        => await _clientService.DeleteScheduleHistoryClientAsync(id);
    #endregion[Schedule History]
}
