using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Infra.Data.Repositorys
{
    public interface IBaseRepository<T> where T : EntityModel
    {
        Task<T> SelectAsync(Guid id);
        Task<List<T>> SelectListAsync();
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(Guid id, T item);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistAsync(Guid id);
    }
}
