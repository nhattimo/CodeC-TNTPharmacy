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
        int ID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        string Name { get; set; }


        [Column(TypeName = "FLOAT")]
        float Price{ get; set; }


        [Column(TypeName = "FLOAT")]
        float Discount { get; set; }


        [Column(TypeName = "INT")]
        int Quantity { get; set; }


        [Column(TypeName = "DATETIME")]
        DateTime CreatedDate { get; set; }



        [Column(TypeName = "VARCHAR")]
        string Image { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        string Description { get; set; }   
        

        int CategoryId { get; set; }
        

        int SupplierId { get; set; }

        [ForeignKey("ID")]
        public virtual Suppliers SUPPLIERS { get; set; }
        int CreatedBy { get; set; }



    }
}
