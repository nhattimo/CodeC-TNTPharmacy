

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("PAY_MENT")]
    public class PayMent
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        //Tổng giá
        [Column(TypeName = "FLOAT")]
        public float TotalPrice { get; set; }

        // Phương thức thanh toán khóa ngoại đến phương thức thanh toán
        public int IDMethod { get; set; }
        [ForeignKey("ID")]
        public virtual PayMentMethond PAYMENTMETHOND { get; set; }

        // ID khách hành khóa ngoại đến user
        public int IDCustomer { get; set; }
        [ForeignKey("ID")]
        public virtual Users USERS { get; set; }
    }
}
