using studioFlaviaBegosso.Domain.Dto;

namespace studioFlaviaBegosso.Domain.Interface.Service.Users;

public interface IWorkService
{
    Task<List<WorkDto>> GetAllWorkAsync();
    Task<WorkDto> GetWorkAsync(Guid id);
}
