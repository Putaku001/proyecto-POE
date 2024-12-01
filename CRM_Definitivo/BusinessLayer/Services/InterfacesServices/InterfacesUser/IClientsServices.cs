using CommonLayer.Entities.Users;

namespace BusinessLayer.Services.InterfacesServices.InterfacesUser
{
    public interface IClientsServices
    {
        IEnumerable<Clients> GetClients();
    }
}