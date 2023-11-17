using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("EMPLOYEES")]
    public class Employees
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        public string Name { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(3)]
        public string Sex { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string Phone { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Email { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Address { get; set; }


        [Column(TypeName = "VARCHAR")]
        public string Image { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string UserName { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Password { get; set; }


        public float Salary { get; set; }

        DateTime StartedDay { get; set; }

        
        
        [Column(TypeName = "VARCHAR")]
        [StringLength(12)]
        public string CCCD { get; set; }



        public int Role { get; set; }
        [ForeignKey("ID")]
        public virtual Roles ROLES { get; set; }
    }
}
