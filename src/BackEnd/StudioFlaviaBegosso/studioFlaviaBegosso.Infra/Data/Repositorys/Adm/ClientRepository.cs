using studioFlaviaBegosso.Domain.Model.Adm;
using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm;

public class ClientRepository : BaseRepository<ClientModel>, IClientRepository
{
    public ClientRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

    public async Task<List<ClientModel>> GetAllClient()
        => await SelectListAsync();

    public async Task<ClientModel> GetClient(Guid id)
        => await SelectAsync(id);

    public async Task<bool> InsertClient(ClientModel client)
    {
        client.DateCreation = DateTime.Now;
        client.CreatedBy = "Flávia Alessandra Begosso";
        ClientModel result = await InsertAsync(client);
        if (result == null) return false;
        
        return true;
    }

    public async Task<bool> UpdateClient(Guid id, ClientModel client)
    {
        client.DateUpdate = DateTime.Now;
        client.EditBy = "Flávia Alessandra Begosso";
        ClientModel result = await UpdateAsync(id, client);
        if (result == null) return false;

        return true;
    }

    public async Task<bool> DeleteClient(Guid id)
    {
        bool result = await DeleteAsync(id);
        if (!result) return false;

        return true;
    }
}
