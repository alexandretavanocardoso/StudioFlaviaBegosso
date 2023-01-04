using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;
using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Business.Services.Users;

public class WorkService : IWorkService
{
    private readonly IWorkRepository _workRepository;
    private readonly IMapper _mapper;

    public WorkService(IWorkRepository workRepository, IMapper mapper)
    {
        _workRepository = workRepository;
        _mapper = mapper;
    }

    public async Task<List<WorkDto>> GetAllWorkAsync()
    {
        List<WorkModel> model = await _workRepository.GetAllWork();
        return _mapper.Map<List<WorkDto>>(model);
    }

    public async Task<WorkDto> GetWorkAsync(Guid id)
    {
        WorkModel model = await _workRepository.GetWork(id);
        return _mapper.Map<WorkDto>(model);
    }
}
