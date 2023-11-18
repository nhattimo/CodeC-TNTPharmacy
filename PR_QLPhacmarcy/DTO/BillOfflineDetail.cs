using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("BILL_OFFLINE_DETAIL")]
    public class BillOfflineDetail
    {
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }

        // Số lượng
        [Column(TypeName = "INT")]
        public int Quantity { get; set; }

        // Giá bán
        [Column(TypeName = "FLOAT")]
        public float SoldPrice { get; set; }

        //Tổng cộng
        [Column(TypeName = "INT")]
        public int TotalAmount { get; set; }


        // ID sản phẩm khóa ngoại đến sản phẩm
        public int IDPruduct { get; set; }
        [ForeignKey("ID")]
        public virtual Products PRODUCTS { get; set; }

        // ID hóa đơn khóa ngoại đến hóa đơn trực tiếp
        public int IDBill { get; set; }
        [ForeignKey("ID")]
        public virtual BillOffline BILLOFFLINE { get; set; }

        
        
        

    }
}
