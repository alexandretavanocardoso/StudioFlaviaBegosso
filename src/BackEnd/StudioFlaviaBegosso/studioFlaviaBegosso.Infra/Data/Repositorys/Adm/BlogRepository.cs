using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm;

public class BlogRepository : BaseRepository<BlogModel>, IBlogRepository
{
    public BlogRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

    public async Task<List<BlogModel>> GetAllBlogAsync()
        => await SelectListAsync();

    public async Task<BlogModel> GetBlogAsync(Guid id)
        => await SelectAsync(id);

    public async Task<bool> InsertBlogAsync(BlogModel blog)
    {
        blog.DateCreation = DateTime.Now;
        blog.CreatedBy = "Flávia Alessandra Begosso";
        BlogModel result = await InsertAsync(blog);
        if (result == null) return false;
        
        return true;
    }

    public async Task<bool> UpdateBlogAsync(Guid id, BlogModel blog)
    {
        blog.DateUpdate = DateTime.Now;
        blog.EditBy = "Flávia Alessandra Begosso";
        BlogModel result = await UpdateAsync(id, blog);
        if (result == null) return false;

        return true;
    }

    public async Task<bool> DeleteBlogAsync(Guid id)
    {
        bool result = await DeleteAsync(id);
        if (!result) return false;

        return true;
    }
}
