using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Stocks
    {
        [Key]
        public DateTime MonthYear { get; set; }



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int IDPruduct { get; set; }
        [ForeignKey("ID")]
        public virtual Products PRODUCTS { get; set; }



        public int FirstQuantity { get; set; }

        public int ImportedQuantity { get; set; }

        public int ExportedQuantity { get; set; }
        public int FinalQuantity { get; set; }

    }
}
