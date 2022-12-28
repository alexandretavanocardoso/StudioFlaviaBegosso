using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm;

public class BlogRepository : IBlogRepository
{
	private StudioFlaviaBegossoContext _studioFlaviaBegossoContext;

    public BlogRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext)
	{
        _studioFlaviaBegossoContext = studioFlaviaBegossoContext;
    }
}
