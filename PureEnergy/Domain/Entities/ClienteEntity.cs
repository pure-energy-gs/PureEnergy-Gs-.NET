using System.ComponentModel.DataAnnotations.Schema;

namespace PureEnergy.Domain.Entities
{
    [Table("T_PE_Clientes")]
    public class ClienteEntity : UserEntity
    {
        public string Registro { get; set; }
    }
}
