using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table("ROLES")]
    public class Roles
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // Tên chức vụ
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
