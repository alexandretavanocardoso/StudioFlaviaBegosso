using studioFlaviaBegosso.Domain.Dto.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IClientService
{
    Task<List<ClientDto>> GetAllClientAsync();
    Task<ClientDto> GetClientAsync(Guid id);
    Task<bool> InsertClientAsync(ClientDto client);
    Task<bool> MarkScheduleInsertAsync(ScheduleClientDto schedule);
    Task<bool> MarkScheduleUpdateAsync(Guid id, ScheduleClientDto schedule);
    Task<bool> UpdateClientAsync(Guid id, ClientDto client);
    Task<bool> DeleteClientAsync(Guid id);
}
