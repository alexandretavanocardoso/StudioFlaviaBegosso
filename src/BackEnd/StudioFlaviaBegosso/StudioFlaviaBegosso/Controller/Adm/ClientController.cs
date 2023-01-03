using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Dto.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.API.EndPoints.Adm;

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

    [HttpGet("get-client")]
    public async Task<ActionResult<List<ClientDto>>> GetAllClient() 
        => await _clientService.GetAllClientAsync();

    [HttpGet("get/{id:Guid}")]
    public async Task<ActionResult<ClientDto>> GetClient(Guid id) 
        => await _clientService.GetClientAsync(id);

    [HttpPost("insert-client")]
    public async Task<ActionResult<bool>> InsertClient([FromBody] ClientDto client) 
        => await _clientService.InsertClientAsync(client);

    [HttpPost("mark-schedule-insert")]
    public async Task<ActionResult<bool>> MarkScheduleInsert([FromBody] ScheduleClientDto schedule)
        => await _clientService.MarkScheduleInsertAsync(schedule);

    [HttpPut("mark-schedule-update")]
    public async Task<ActionResult<bool>> MarkScheduleUpdate(Guid id, [FromBody] ScheduleClientDto schedule)
        => await _clientService.MarkScheduleUpdateAsync(id, schedule);

    [HttpPut("update-client/{id:Guid}")]
    public async Task<ActionResult<bool>> UpdateClient(Guid id, [FromBody] ClientDto client) 
        => await _clientService.UpdateClientAsync(id, client);

    [HttpDelete("delete-client/{id:Guid}")]
    public async Task<ActionResult<bool>> DeleteClient(Guid id) 
        => await _clientService.DeleteClientAsync(id);
}
