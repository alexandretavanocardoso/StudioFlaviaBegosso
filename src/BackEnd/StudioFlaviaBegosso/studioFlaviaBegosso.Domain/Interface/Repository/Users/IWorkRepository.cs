using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Users;

public interface IWorkRepository {
    Task<List<WorkModel>> GetAllWork();
    Task<WorkModel> GetWork(Guid id);
}
