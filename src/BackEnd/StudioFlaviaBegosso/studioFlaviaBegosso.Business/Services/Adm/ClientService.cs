using AutoMapper;
using studioFlaviaBegosso.Domain.Dto.Adm;
using studioFlaviaBegosso.Domain.Interface.Repository.Adm;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;

namespace StudioFlaviaBegosso.Business.Services.Adm;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IScheduleClientRepository _scheduleClientRepository;
    private readonly IScheduleClientHistoryRepository _scheduleClientHistoryRepository;
    private readonly IMapper _mapper;

    public ClientService(IClientRepository clientRepository,
                         IScheduleClientRepository scheduleClientRepository,
                         IScheduleClientHistoryRepository scheduleClientHistoryRepository,
                         IMapper mapper)
    {
        _scheduleClientRepository = scheduleClientRepository;
        _scheduleClientHistoryRepository = scheduleClientHistoryRepository;
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<List<ClientDto>> GetAllClientAsync()
    {
        List<ClientModel> model = await _clientRepository.GetAllClient();
        return _mapper.Map<List<ClientDto>>(model);
    }

    public async Task<ClientDto> GetClientAsync(Guid id)
    {
        ClientModel model = await _clientRepository.GetClient(id);
        return _mapper.Map<ClientDto>(model);
    }

    public async Task<bool> InsertClientAsync(ClientDto client)
    {
        ClientModel model = _mapper.Map<ClientModel>(client);
        return await _clientRepository.InsertClient(model);
    }

    public async Task<bool> MarkScheduleInsertAsync(ScheduleClientDto schedule)
    {
        bool result = await InsertMarkScheduleAsync(schedule);
        if (!result) return false;

        bool resultHistory = await InsertMarkScheduleHistoryAsync(schedule, false, true);
        if (!resultHistory) return false;

        return true;
    }

    public async Task<bool> MarkScheduleUpdateAsync(Guid id, ScheduleClientDto schedule)
    {
        bool result = await UpdateMarkScheduleAsync(id, schedule);
        if (!result) return false;

        bool resultHistory = await InsertMarkScheduleHistoryAsync(schedule, true, false);
        if (!resultHistory) return false;

        return true;
    }

    public async Task<bool> UpdateClientAsync(Guid id, ClientDto client)
    {
        ClientModel model = _mapper.Map<ClientModel>(client);
        return await _clientRepository.UpdateClient(id, model);
    }

    public async Task<bool> DeleteClientAsync(Guid id)
        => await _clientRepository.DeleteClient(id);

    #region[Privados]
    private async Task<bool> InsertMarkScheduleAsync(ScheduleClientDto schedule)
    {
        ScheduleClientModel model = _mapper.Map<ScheduleClientModel>(schedule);
        return await _scheduleClientRepository.InsertMarkSchedule(model);
    }

    private async Task<bool> UpdateMarkScheduleAsync(Guid id, ScheduleClientDto schedule)
    {
        ScheduleClientModel model = _mapper.Map<ScheduleClientModel>(schedule);
        return await _scheduleClientRepository.UpdateMarkSchedule(id, model);
    }

    private async Task<bool> InsertMarkScheduleHistoryAsync(ScheduleClientDto schedule, bool isUpdate, bool isInsert)
    {
        ScheduleClientHistoryModel modelHistory = _mapper.Map<ScheduleClientHistoryModel>(schedule);
        bool resultScheduleHistory = await _scheduleClientHistoryRepository.InsertMarkScheduleHistory(modelHistory, isUpdate, isInsert);
        if (!resultScheduleHistory) return false;

        return true;
    }
    #endregion[Privados]
}
