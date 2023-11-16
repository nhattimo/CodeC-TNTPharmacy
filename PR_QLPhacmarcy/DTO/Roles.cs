﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("ROLES")]
    public class Roles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(20)]
        string Name { get; set; }
    }
}
