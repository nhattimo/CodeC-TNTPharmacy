using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("CATEGORYS")]
    public class Categorys
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        public string Name { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(10)]
        public string Status { get; set; }


        [Column(TypeName = "DATETIME")]
        DateTime CreatedDate {get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Description { get; set; }



        public int CreatedBy { get; set; }
        [ForeignKey("ID")]
        public virtual Employees EMPLOYEES  { get; set; }
        
    }
}
