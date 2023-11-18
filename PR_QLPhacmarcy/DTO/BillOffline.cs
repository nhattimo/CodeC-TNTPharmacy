using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("BILL_OFFLINE")]
    public class BillOffline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // Ngày tạo bill
        [Column(TypeName = "DATETIME")]
        DateTime CreatedDate { get; set; }

        // Tổng số lượng
        [Column(TypeName = "INT")]
        public int TotalAmount { get; set; }

        // Người tạo khóa ngoại đến ID Nhân viên
        public int CreatedBy { get; set; }
        [ForeignKey("ID")]
        public virtual Employees EMPLOYEES { get; set; }

        // ID khách hàng khóa ngoại đến ID Khách hàng
        public int? IDCustomer { get; set; }
        [ForeignKey("ID")]
        public virtual Users USERS { get; set; }
    }
}
