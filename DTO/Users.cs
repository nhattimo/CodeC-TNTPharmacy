using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("USERS")]
    public class Users
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // Tên
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(30)]
        public string Name { get; set; }

        // Giới tính
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(3)]
        public string Sex { get; set; }

        // Ngày sinh
        [Column(TypeName = "DATETIME")]
        public DateTime DateOfBirth { get; set; }

        // Số điện thoại
        [Column(TypeName = "VARCHAR")]
        [MaxLength(10)]
        public string Phone { get; set; }

        //Điểm số 
        [Column(TypeName = "VARCHAR")]
        [MaxLength(10)]
        public string Point { get; set; }

        // Địa chỉ
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]
        public string Address { get; set; }

        // Email
        [Column(TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string Email { get; set; }

        // Ảnh
        [Column(TypeName = "VARCHAR")]
        public string Image { get; set; }

       
        // ID tài khoản khóa ngoại đến tài khoản
        public int IDTK { get; set; }
        [ForeignKey("IDTK")]
        public virtual Account ACCOUNT { get; set; }

    }
}
