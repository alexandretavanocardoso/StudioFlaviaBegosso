using studioFlaviaBegosso.Domain.Dto.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IMaintenanceService
{
    Task<List<MaintenanceDto>> GetAllMaintenanceAsync();
    Task<MaintenanceDto> GetMaintenanceAsync(Guid id);
    Task<bool> InsertMaintenanceAsync(MaintenanceDto maintenance);
    Task<bool> UpdateMaintenanceAsync(Guid id, MaintenanceDto maintenance);
    Task<bool> DeleteMaintenanceAsync(Guid id);
}
