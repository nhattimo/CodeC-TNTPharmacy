using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DTO
{
    [Table("WARE_HOUSING_DETAILS")]
    public class WareHousingDetails
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // ID sản phẩm khóa ngoại đến sản phẩm
        public int IDPruduct { get; set; }
        [ForeignKey("IDPruduct")]
        public virtual Products PRODUCTS { get; set; }

        // kho khóa ngoại đến kho
        public int IDWareHousing { get; set; }
        [ForeignKey("IDWareHousing")]
        public virtual WareHousing WAREHOUSING { get; set; }

        //Số lượng
        [Column(TypeName = "INT")]
        public int Quantity { get; set; }

        // Giá nhập khẩu
        [Column(TypeName = "FLOAT")]
        public float ImportedPrice { get; set; }

        // tổng cộng
        [Column(TypeName = "FLOAT")]
        public float TotalAmount { get; set; }
    }
}
