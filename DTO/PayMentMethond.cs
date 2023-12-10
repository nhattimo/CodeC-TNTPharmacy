using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("PAYMENTMETHOND")]
    public class PayMentMethond
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [MaxLength(30)]
        public string NameMethod { get; set; }

    }
}
