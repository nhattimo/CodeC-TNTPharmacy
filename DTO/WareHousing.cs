using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DTO
{
    [Table("WARE_HOUSING")]
    public class WareHousing
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // Ngày nhập kho
        [Column(TypeName = "DATETIME")]
        public DateTime ImportedDate { get; set; }

        // Tổng số lượng
        [Column(TypeName = "FLOAT")]
        public float TotalAmount { get; set; }

        // Tạo bởi khóa ngoại đến nhân viên
        public int ImportedBy { get; set; }
        [ForeignKey("ImportedBy")]
        public virtual Employees EMPLOYEES { get; set; }
    }
}
