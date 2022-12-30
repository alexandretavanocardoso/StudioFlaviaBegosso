using studioFlaviaBegosso.Domain.Dto;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IWorkService
{
    Task<List<WorkDto>> GetAllWorkAsync();
    Task<WorkDto> GetWorkAsync(Guid id);
    Task<bool> InsertWorkAsync(WorkDto work);
    Task<bool> UpdateWorkAsync(Guid id, WorkDto work);
    Task<bool> DeleteWorkAsync(Guid id);
}
