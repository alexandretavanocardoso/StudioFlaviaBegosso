using studioFlaviaBegosso.Domain.Dto.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IClientService
{
    #region[Client]
    Task<List<ClientDto>> GetAllClientAsync();
    Task<ClientDto> GetClientAsync(Guid id);
    Task<bool> InsertClientAsync(ClientDto client);    
    Task<bool> UpdateClientAsync(Guid id, ClientDto client);
    Task<bool> DeleteClientAsync(Guid id);
    #endregion[Client]

    #region[Schedule]
    Task<List<ScheduleClientDto>> GetAllScheduleClientAsync();
    Task<ScheduleClientDto> GetScheduleClientAsync(Guid id);
    Task<bool> MarkScheduleInsertAsync(ScheduleClientDto schedule);
    Task<bool> MarkScheduleUpdateAsync(Guid id, ScheduleClientDto schedule);
    Task<bool> DeleteScheduleClientAsync(Guid id);
    #endregion[Schedule]

    #region[Schedule History]
    Task<List<ScheduleClientHistoryDto>> GetAllScheduleHistoryClientAsync();
    Task<bool> DeleteScheduleHistoryClientAsync(Guid id);
    #endregion[Schedule History]
}
