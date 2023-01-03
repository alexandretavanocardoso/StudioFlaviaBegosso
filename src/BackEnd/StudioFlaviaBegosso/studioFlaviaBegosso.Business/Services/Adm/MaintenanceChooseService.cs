using AutoMapper;
using studioFlaviaBegosso.Domain.Dto.Adm;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class MaintenanceChooseService : IMaintenanceChooseService
{
	private readonly IMaintenanceChooseRepository _maintenanceChooseRepository;
    private readonly IMapper _mapper;

    public MaintenanceChooseService(IMaintenanceChooseRepository maintenanceChooseRepository, IMapper mapper)
	{
        _maintenanceChooseRepository = maintenanceChooseRepository;
        _mapper = mapper;
    }

    public async Task<List<MaintenanceChooseDto>> GetAllMaintenanceChooseAsync()
    {
        List<MaintenanceChooseModel> model = await _maintenanceChooseRepository.GetAllMaintenanceChoose();
        return _mapper.Map<List<MaintenanceChooseDto>>(model);
    }

    public async Task<MaintenanceChooseDto> GetMaintenanceChooseAsync(Guid id)
    {
        MaintenanceChooseModel model = await _maintenanceChooseRepository.GetMaintenanceChoose(id);
        return _mapper.Map<MaintenanceChooseDto>(model);
    }

    public async Task<bool> InsertMaintenanceChooseAsync(MaintenanceChooseDto maintenanceChoose)
    {
        MaintenanceChooseModel model = _mapper.Map<MaintenanceChooseModel>(maintenanceChoose);
        return await _maintenanceChooseRepository.InsertMaintenanceChoose(model);
    }

    public async Task<bool> UpdateMaintenanceChooseAsync(Guid id, MaintenanceChooseDto maintenanceChoose)
    {
        MaintenanceChooseModel model = _mapper.Map<MaintenanceChooseModel>(maintenanceChoose);
        return await _maintenanceChooseRepository.UpdateMaintenanceChoose(id, model);
    }

    public async Task<bool> DeleteMaintenanceChooseAsync(Guid id)
        => await _maintenanceChooseRepository.DeleteMaintenanceChoose(id);
}
