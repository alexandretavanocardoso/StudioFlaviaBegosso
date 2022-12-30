using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;

public interface IWorkRepository {
    Task<List<WorkModel>> GetAllWork();
    Task<WorkModel> GetWork(Guid id);
    Task<bool> InsertWork(WorkModel work);
    Task<bool> UpdateWork(Guid id, WorkModel work);
    Task<bool> DeleteWork(Guid id);
}
