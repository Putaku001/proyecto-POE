using CommonLayer.Entities.Users;

namespace DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser
{
    public interface IClientsRepositories
    {
        IEnumerable<Clients> GetClients();
    }
}