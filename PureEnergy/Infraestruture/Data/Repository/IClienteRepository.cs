using PureEnergy.Domain.Entities;

namespace PureEnergy.Infraestruture.Data.Repository
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteEntity> GetAllClientes();
        ClienteEntity GetClienteById(int id);
        ClienteEntity GetClienteByRegistro(string cro);
        ClienteEntity AddCliente(ClienteEntity entity);
        ClienteEntity UpdateClienteById(int id, ClienteEntity entity);
        ClienteEntity DeleteClienteById(int id);
    }
}
