using studioFlaviaBegosso.Domain.Dto.Adm;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class MaintenanceService : IMaintenanceService
{
	private readonly IMaintenanceRepository _maintenanceRepository;
    private readonly IMapper _mapper;

    public MaintenanceService(IMaintenanceRepository maintenanceRepository, IMapper mapper)
	{
        _maintenanceRepository = maintenanceRepository;
        _mapper = mapper;
    }

    public async Task<List<MaintenanceDto>> GetAllMaintenanceAsync()
    {
        List<MaintenanceModel> model = await _maintenanceRepository.GetAllMaintenance();
        return _mapper.Map<List<MaintenanceDto>>(model);
    }

    public async Task<MaintenanceDto> GetMaintenanceAsync(Guid id)
    {
        MaintenanceModel model = await _maintenanceRepository.GetMaintenance(id);
        return _mapper.Map<MaintenanceDto>(model);
    }

    public async Task<bool> InsertMaintenanceAsync(MaintenanceDto maintenance)
    {
        MaintenanceModel model = _mapper.Map<MaintenanceModel>(maintenance);
        return await _maintenanceRepository.InsertMaintenance(model);
    }

    public async Task<bool> UpdateMaintenanceAsync(Guid id, MaintenanceDto maintenance)
    {
        MaintenanceModel model = _mapper.Map<MaintenanceModel>(maintenance);
        return await _maintenanceRepository.UpdateMaintenance(id, model);
    }

    public async Task<bool> DeleteMaintenanceAsync(Guid id)
        => await _maintenanceRepository.DeleteMaintenance(id);
}
