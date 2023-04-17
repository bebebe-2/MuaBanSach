using System.ComponentModel.DataAnnotations.Schema;

namespace Mubasa.Models
{
    [Table("Provinces", Schema = "Address")]
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Ghn { get; set; }

        public ICollection<Address> Addresses { get; set; } = default!;
        public ICollection<OrderHeader> OrderHeaders { get; set; } = default!;
    }
}
