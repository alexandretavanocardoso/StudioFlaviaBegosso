using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Domain.Interface.Service;

namespace StudioFlaviaBegosso.Business.Services;

public class WorkService : IWorkService
{
    private readonly IWorkRepository _workRepository;
    public WorkService(IWorkRepository workRepository)
    {
        _workRepository = workRepository;
    }
}
