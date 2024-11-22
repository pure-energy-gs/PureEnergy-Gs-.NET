
using PureEnergy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace PureEnergy.Infraestructure.Data.AppData;

public class ApplicationContext : DbContext
{
    public DbSet<ClienteEntity> Clientes { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
