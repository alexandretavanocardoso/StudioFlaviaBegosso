using studioFlaviaBegosso.Domain.Dto.Adm;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class ProcedureService : IProcedureService
{
	private readonly IProcedureRepository _procedureRepository;
    private readonly IMapper _mapper;

    public ProcedureService(IProcedureRepository procedureRepository, IMapper mapper)
	{
        _procedureRepository = procedureRepository;
        _mapper = mapper;
    }

    public async Task<List<ProcedureDto>> GetAllProcedureAsync()
    {
        List<ProcedureModel> model = await _procedureRepository.GetAllProcedure();
        return _mapper.Map<List<ProcedureDto>>(model);
    }

    public async Task<ProcedureDto> GetProcedureAsync(Guid id)
    {
        ProcedureModel model = await _procedureRepository.GetProcedure(id);
        return _mapper.Map<ProcedureDto>(model);
    }

    public async Task<bool> InsertProcedureAsync(ProcedureDto procedure)
    {
        ProcedureModel model = _mapper.Map<ProcedureModel>(procedure);
        return await _procedureRepository.InsertProcedure(model);
    }

    public async Task<bool> UpdateProcedureAsync(Guid id, ProcedureDto procedure)
    {
        ProcedureModel model = _mapper.Map<ProcedureModel>(procedure);
        return await _procedureRepository.UpdateProcedure(id, model);
    }

    public async Task<bool> DeleteProcedureAsync(Guid id)
        => await _procedureRepository.DeleteProcedure(id);
}
