using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    [Table("STOCKS")]
    public class Stocks
    {
        //ID
        [Key, Column(Order = 0)]
        public DateTime MonthYear { get; set; }

        // ID sản phẩm khóa ngoại đến sản phẩm
        [Key, Column(Order = 1)]
        public int IDPruduct { get; set; }
        [ForeignKey("IDPruduct")]
        public virtual Products PRODUCTS { get; set; }

        // số lượng ban đầu
        public int FirstQuantity { get; set; }

        // số lượng nhập
        public int ImportedQuantity { get; set; }

        // số lượng xuất
        public int ExportedQuantity { get; set; }
        
        // số lượng còn lại
        public int FinalQuantity { get; set; }

    }
}
