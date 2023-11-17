using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class WareHousingDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        public int IDPruduct { get; set; }
        [ForeignKey("ID")]
        public virtual Products PRODUCTS { get; set; }

        public int IDWareHousing { get; set; }
        [ForeignKey("ID")]
        public virtual Products PRODUCTSa { get; set; }
    }
}
