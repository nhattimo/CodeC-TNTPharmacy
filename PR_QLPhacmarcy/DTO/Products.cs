using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    [Table ("PRODUCTS")]
    public class Products
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // khoa tu sinh
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        public string Name { get; set; }


        [Column(TypeName = "FLOAT")]
        public float Price { get; set; }


        [Column(TypeName = "FLOAT")]
        public float Discount { get; set; }



        [Column(TypeName = "INT")]
        public int Quantity { get; set; }



        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }



        [Column(TypeName = "VARCHAR")]
        public string Image { get; set; }



        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        public string Description { get; set; }



        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Categorys CATEGORYS { get; set; }



        public int SupplierId { get; set; }
        [ForeignKey("ID")]
        public virtual Suppliers SUPPLIERS { get; set; }



        public int CreatedBy { get; set; }
        [ForeignKey("ID")]
        public virtual Users USERS { get; set; }

    }
}
