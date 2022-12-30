using Microsoft.EntityFrameworkCore;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityModel
    {
        private readonly StudioFlaviaBegossoContext _studioFlaviaBegossoContext;
        private DbSet<T> _dbSet;

        public BaseRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext)
        {
            _studioFlaviaBegossoContext = studioFlaviaBegossoContext;
            _dbSet = _studioFlaviaBegossoContext.Set<T>();
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dbSet?.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<T>> SelectListAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();

                _dbSet.Add(item);

                await _studioFlaviaBegossoContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<T> UpdateAsync(Guid id, T item)
        {
            try
            {
                var registro = await _dbSet.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if (registro == null) return null;

                item.Id = id;
                _studioFlaviaBegossoContext.Entry(registro).CurrentValues
                                                           .SetValues(item);

                await _studioFlaviaBegossoContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var item = await _dbSet.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if (item == null) return false;

                _dbSet.Remove(item);

                await _studioFlaviaBegossoContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dbSet.AnyAsync(p => p.Id.Equals(id));
        }
    }
}
