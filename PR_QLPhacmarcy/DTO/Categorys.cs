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
        int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        string Name { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(10)]
        string Status { get; set; }


        [Column(TypeName = "DATETIME")]
        DateTime CreatedDate {get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        string Description { get; set; }



        int CreatedBy { get; set; }
        
    }
}
