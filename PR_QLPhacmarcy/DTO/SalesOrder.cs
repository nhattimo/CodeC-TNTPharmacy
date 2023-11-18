using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("SALES_ORDER")]
    public class SalesOrder
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        //Ngày đặt
        [Column(TypeName = "DATETIME")]
        public DateTime OrderDate { get; set; }

        //Trạng thái đơn hàng
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(40)]
        public string Status { get; set; }

        // Tổng cộng
        [Column(TypeName = "FLOAT")]
        public float TotalAmount { get; set; }

        //ID vận chuyển khóa ngoại đến vận chuyển
        public int IDShipping { get; set; }
        [ForeignKey("ID")]
        public virtual Shipping SHIPPING { get; set; }

        // ID phương thức thanh toán khóa ngoại đến phương thức thanh toán
        public int IDPayment { get; set; }
        [ForeignKey("ID")]
        public virtual PayMent PAYMENT { get; set; }

        // ID Người khách hàng khóa ngoại đến bảng User
        public int IDCustomer { get; set; }
        [ForeignKey("ID")]
        public virtual Users USERS { get; set; }
    }
}
