using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys;

public class BlogRepository : IBlogRepository
{
	private StudioFlaviaBegossoContext _studioFlaviaBegossoContext;

    public BlogRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext)
	{
        _studioFlaviaBegossoContext = studioFlaviaBegossoContext;
    }
}
