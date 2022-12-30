using Microsoft.EntityFrameworkCore;
using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm
{
    public class GalleryRepository : BaseRepository<GalleryModel>, IGalleryRepository
    {
        private readonly DbSet<GalleryModel> _dataSet;

        public GalleryRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext)
        {
            _dataSet = studioFlaviaBegossoContext.Set<GalleryModel>();
        }

        public async Task<List<GalleryModel>> GetAllGallery()
        {
            return await SelectListAsync();
        }

        public async Task<GalleryModel> GetGallery(Guid id)
        {
            return await SelectAsync(id);
        }

        public async Task<bool> InsertGallery(GalleryModel gallery)
        {
            var result = await InsertAsync(gallery);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> UpdateGallery(Guid id, GalleryModel gallery)
        {
            var result = await UpdateAsync(id, gallery);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> DeleteGallery(Guid id)
        {
            var result = await DeleteAsync(id);
            if (!result) return false;

            return true;
        }
    }
}
