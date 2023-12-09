using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;


namespace DTO
{
    [Table("ACCOUNT")]
    public class Account
    {
        public Account(string nameAccount, string password, int role)
        {
            AccountName = nameAccount;
            Password = password;
            Role = role;
        }
        public Account()
        {
        }

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
