using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table ("PRODUCTS")]
    public class Products
    {
        public Products(string name, float price, float discount, int quantity, DateTime createdDate,
                    string image, string description, DateTime productionDate, DateTime expiryDate,
                    int supplierId, int categoryId, int createdBy)
        {
            Name = name;
            Price = price;
            Discount = discount;
            Quantity = quantity;
            CreatedDate = createdDate;
            Image = image;
            Description = description;
            ProductionDate = productionDate;
            ExpiryDate = expiryDate;
            SupplierId = supplierId;
            CategoryId = categoryId;
            CreatedBy = createdBy;
        }
        public Products()
        {
           
        }
        // ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID{ get; set; }

        // Tên sản phẩm
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(30)]
        public string Name { get; set; }

        // Giá 
        [Column(TypeName = "FLOAT")]
        public float Price { get; set; }

        // giá bán giảm giá 
        [Column(TypeName = "FLOAT")]
        public float Discount { get; set; }

        //Số lượng
        [Column(TypeName = "INT")]
        public int Quantity { get; set; }

        // Ngày tạo
        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        // ảnh
        [Column(TypeName = "VARCHAR")]
        public string Image { get; set; }

        // mô tả
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(250)]
        public string Description { get; set; }
       
        // Ngày sản xuất
        [Column(TypeName = "DATETIME")]
        public DateTime ProductionDate { get; set; }

        // Ngày hết hạn
        [Column(TypeName = "DATETIME")]
        public DateTime ExpiryDate { get; set; }

        // nhà cung cấp khóa ngoại đến nhà cung cấp
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Suppliers SUPPLIERS { get; set; }

        // Loại sản phẩm khóa ngoại đến loại
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Categorys CATEGORYS { get; set; }

        // được tảo bởi khóa ngoại đến nhân viên
        public int CreatedBy { get; set; }
        /*[ForeignKey("CreatedBy")]
        public virtual Employees EMPLOYEES { get; set; }*/

    }
}
