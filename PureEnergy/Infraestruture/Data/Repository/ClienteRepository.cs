using Microsoft.EntityFrameworkCore;
using PureEnergy.Domain.Entities;
using PureEnergy.Infraestructure.Data.AppData;

namespace PureEnergy.Infraestruture.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationContext _context;

        public ClienteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<ClienteEntity> GetAllClientes()
        {
            return _context.Set<ClienteEntity>().ToList();
        }

        public ClienteEntity GetClienteById(int id)
        {
            return _context.Set<ClienteEntity>().Find(id);
        }

        public ClienteEntity GetClienteByCro(string registro)
        {
            return _context.Set<ClienteEntity>().FirstOrDefault(d => d.Registro == registro);
        }

        public ClienteEntity AddCliente(ClienteEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public ClienteEntity DeleteClienteById(int id)
        {
            var entity = _context.Set<ClienteEntity>().Find(id);
            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }

            return entity;
        }

        public ClienteEntity UpdateClienteById(int id, ClienteEntity entity)
        {
            var existingEntity = _context.Set<ClienteEntity>().Find(id);

            if (existingEntity != null)
            {
                existingEntity.Nome = entity.Nome;
                existingEntity.Email = entity.Email;
                existingEntity.CPF = entity.CPF;
                existingEntity.Registro = entity.Registro;

                _context.Entry(existingEntity).State = EntityState.Modified;
                _context.SaveChanges();
            }

            return existingEntity;
        }

        public ClienteEntity GetClienteByRegistro(string cro)
        {
            throw new NotImplementedException();
        }
    }
}
