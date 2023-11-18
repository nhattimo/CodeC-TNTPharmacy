using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("SHIPPING")]
    public class Shipping
    {
        //ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // Giá ship
        [Column(TypeName = "FLOAT")]
        public float Price { get; set; }

        // tên
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(30)]
        public string Name { get; set; }
        
    }
}
