using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;

namespace studioFlaviaBegosso.Business.Services.Users;

public class WorkService : IWorkService
{
    private readonly IWorkRepository _workRepository;
    public WorkService(IWorkRepository workRepository)
    {
        _workRepository = workRepository;
    }
}
