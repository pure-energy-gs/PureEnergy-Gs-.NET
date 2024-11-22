using PureEnergy.Application.DTOs;
using PureEnergy.Application.Interfaces;
using PureEnergy.Domain.Entities;
using PureEnergy.Infraestruture.Data.Repository;

namespace PureEnergy.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteApplicationService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ClienteEntity Add(ClienteDTO clienteDTO)
        {
            return _clienteRepository.AddCliente(new ClienteEntity
            {
                Nome = clienteDTO.Nome,
                Email = clienteDTO.Email,
                CPF = clienteDTO.CPF,
                Registro = clienteDTO.Registro
            });
        }

        public ClienteEntity DeleteById(int id)
        {
            return _clienteRepository.DeleteClienteById(id);
        }

        public IEnumerable<ClienteEntity> GetAll()
        {
            return _clienteRepository.GetAllClientes();
        }

        public ClienteEntity GetByCro(string cro)
        {
            return _clienteRepository.GetClienteByRegistro(cro);
        }

        public ClienteEntity GetById(int id)
        {
            return _clienteRepository.GetClienteById(id);
        }

        public ClienteEntity GetByRegistro(string registro)
        {
            throw new NotImplementedException();
        }

        public ClienteEntity Update(int id, ClienteDTO clienteDTO)
        {
            return _clienteRepository.UpdateClienteById(id, new ClienteEntity
            {
                Nome = clienteDTO.Nome,
                Email = clienteDTO.Email,
                CPF = clienteDTO.CPF,
                Registro = clienteDTO.Registro
            });
        }
    }
}
