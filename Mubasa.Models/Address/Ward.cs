using System.ComponentModel.DataAnnotations.Schema;

namespace Mubasa.Models
{
    [Table("Wards", Schema = "Address")]
    public class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Id_Ghn { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }

        public ICollection<Address> Addresses { get; set; } = default!;
        public ICollection<OrderHeader> OrderHeaders { get; set; } = default!;
    }
}
