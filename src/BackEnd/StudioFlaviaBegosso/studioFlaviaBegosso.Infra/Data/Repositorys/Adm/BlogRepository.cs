using Microsoft.EntityFrameworkCore;
using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm;

public class BlogRepository : BaseRepository<BlogModel>, IBlogRepository
{
    private readonly DbSet<BlogModel> _dataSet;

    public BlogRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext)
	{
        _dataSet = studioFlaviaBegossoContext.Set<BlogModel>();
    }

    public async Task<List<BlogModel>> GetAllBlogAsync()
    {
        return await SelectListAsync();
    }

    public async Task<BlogModel> GetBlogAsync(Guid id)
    {
        return await SelectAsync(id);
    }

    public async Task<bool> InsertBlogAsync(BlogModel blog)
    {
        var result = await InsertAsync(blog);
        if (result == null) return false;
        
        return true;
    }

    public async Task<bool> UpdateBlogAsync(Guid id, BlogModel blog)
    {
        var result = await UpdateAsync(id, blog);
        if (result == null) return false;

        return true;
    }

    public async Task<bool> DeleteBlogAsync(Guid id)
    {
        var result = await DeleteAsync(id);
        if (!result) return false;

        return true;
    }
}
