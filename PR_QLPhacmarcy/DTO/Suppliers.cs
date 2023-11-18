using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("SUPPLIERS")]
    public class Suppliers
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // Tên nhà cung cấp
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(30)]
        public string Name { get; set; }

        // địa chỉ
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
        public string Address { get; set; }
    }
}
