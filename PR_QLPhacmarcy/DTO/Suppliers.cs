using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("SUPPLIERS")]
    public class Suppliers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        public string Name { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Address { get; set; }
    }
}
