using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("CATEGORYS")]
    public class Categorys
    {

        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        //Tên loại
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(30)]
        public string Name { get; set; }

        // Trạng thái
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(10)]
        public string Status { get; set; }

        // Ngày tạo
        [Column(TypeName = "DATETIME")]
        DateTime CreatedDate {get; set; }

        // Mô tả 
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]
        public string Description { get; set; }

        // Người tạo khóa ngoại đến nhân viên
        public int CreatedBy { get; set; }
        [ForeignKey("ID")]
        public virtual Employees EMPLOYEES  { get; set; }
        
    }
}
