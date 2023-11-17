using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DTO
{
    public class WareHousing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        public DateTime ImportedDate { get; set; }
        public float TotalAmount { get; set; }

        public int ImportedBy { get; set; }
        [ForeignKey("ID")]
        public virtual Employees EMPLOYEES { get; set; }
    }
}
