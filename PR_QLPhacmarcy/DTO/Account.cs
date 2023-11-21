using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("ACCOUNT")]
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // tên tài khoản
        [Column(TypeName = "VARCHAR")]
        [MaxLength(30)]
        public string AccountName { get; set; }

        // Mật khẩu
        [Column(TypeName = "VARCHAR")]
        [MaxLength(30)]
        public string Password { get; set; }

        // Vai trò khóa ngoại đến bảng roles
        public int Role { get; set; }
        [ForeignKey("Role")]
        public virtual Roles ROLES { get; set; }
    }
}
