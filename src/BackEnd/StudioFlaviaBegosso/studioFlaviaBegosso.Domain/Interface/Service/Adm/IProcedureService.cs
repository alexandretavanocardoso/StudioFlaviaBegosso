using studioFlaviaBegosso.Domain.Dto.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IProcedureService
{
    Task<List<ProcedureDto>> GetAllProcedureAsync();
    Task<ProcedureDto> GetProcedureAsync(Guid id);
    Task<bool> InsertProcedureAsync(ProcedureDto procedure);
    Task<bool> UpdateProcedureAsync(Guid id, ProcedureDto procedure);
    Task<bool> DeleteProcedureAsync(Guid id);
}
