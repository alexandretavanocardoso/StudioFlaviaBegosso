using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class WorkService : IWorkService
{
    private readonly IWorkRepository _workRepository;
    public WorkService(IWorkRepository workRepository)
    {
        _workRepository = workRepository;
    }
}
