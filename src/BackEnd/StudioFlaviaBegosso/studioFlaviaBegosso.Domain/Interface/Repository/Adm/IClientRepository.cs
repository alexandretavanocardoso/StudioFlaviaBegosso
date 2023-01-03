using studioFlaviaBegosso.Domain.Model.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IClientRepository
{
    Task<List<ClientModel>> GetAllClient();
    Task<ClientModel> GetClient(Guid id);
    Task<bool> InsertClient(ClientModel client);
    Task<bool> UpdateClient(Guid id, ClientModel client);
    Task<bool> DeleteClient(Guid id);
}
