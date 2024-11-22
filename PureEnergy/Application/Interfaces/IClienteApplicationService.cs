using PureEnergy.Application.DTOs;
using PureEnergy.Domain.Entities;

namespace PureEnergy.Application.Interfaces
{
    public interface IClienteApplicationService
    {
        IEnumerable<ClienteEntity> GetAll();
        ClienteEntity GetById(int id);
        ClienteEntity GetByRegistro(string registro);
        ClienteEntity Add(ClienteDTO clienteDTO);
        ClienteEntity Update(int id, ClienteDTO clienteDTO);
        ClienteEntity DeleteById(int id);
    }
}
