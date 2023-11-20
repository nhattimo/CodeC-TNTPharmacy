using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("SALES_ORDER_DETAIL")]
    public class SalesOrderDetail
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

        // Tổng cộng
        [Column(TypeName = "INT")]
        public int TotalAmount { get; set; }

        //ID sản phẩm khóa ngoại đến sản phẩm
        public int IDPruduct { get; set; }
        [ForeignKey("IDPruduct")]
        public virtual Products PRODUCTS { get; set; }

        // ID đơn hàng online khóa ngoại đến đơn hàng online
        public int IDSalesOrder { get; set; }
        [ForeignKey("IDSalesOrder")]
        public virtual SalesOrder SALESORDER { get; set; }


        


    }
}
