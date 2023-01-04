using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;
using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Business.Services.Adm;

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

    public async Task<bool> InsertWorkAsync(WorkDto work)
    {
        work.Image = ConvertStringToArrayByte(work);
        WorkModel model = _mapper.Map<WorkModel>(work);
        return await _workRepository.InsertWork(model);
    }

    public async Task<bool> UpdateWorkAsync(Guid id, WorkDto work)
    {
        work.Image = ConvertStringToArrayByte(work);
        WorkModel model = _mapper.Map<WorkModel>(work);
        return await _workRepository.UpdateWork(id, model);
    }

    public async Task<bool> DeleteWorkAsync(Guid id)
        => await _workRepository.DeleteWork(id);

    #region[Privados]
    private byte[] ConvertStringToArrayByte(WorkDto work)
    {
        Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
        string image = regex.Replace(work.ImageString, string.Empty);
        work.Image = Convert.FromBase64String(image);

        return work.Image;
    }
    #endregion[Privados]
}
