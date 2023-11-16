using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("USERS")]
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        string Name { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(3)]
        string Sex { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        string Phone { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        string Email { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        string Address { get; set; }


        [Column(TypeName = "VARCHAR")]
        string Image { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        string UserName { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        string Password { get; set; }


        
        int Role { get; set; }
        [ForeignKey("ID")]
        public virtual Roles ROLES { get; set; }

    }
}
