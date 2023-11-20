using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("EMPLOYEES")]
    public class Employees
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

        // tên tài khoản
        [Column(TypeName = "VARCHAR")]
        [MaxLength(30)]
        public string UserName { get; set; }

        // Mật khẩu
        [Column(TypeName = "VARCHAR")]
        [MaxLength(30)]
        public string Password { get; set; }

        // Lương
        [Column(TypeName = "FLOAT")]
        public float Salary { get; set; }

        // Ngày vào làm
        public DateTime StartedDay { get; set; }

        // CCCD
        [Column(TypeName = "VARCHAR")]
        [MaxLength(12)]
        public string CCCD { get; set; }

        // Chức vụ khóa ngoại đến bản Roles
        public int Role { get; set; }
        [ForeignKey("Role")]
        public virtual Roles ROLES { get; set; }
    }
}
