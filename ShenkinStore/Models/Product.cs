using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenkinStore.Models
{
    public class Product
    {
      
       


        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Color")]
        public Color Colorr { get; set; }
        [Display(Name = "Product Type")]
        public ProductType productType { get; set; }
        [Display(Name = "Product Brand")]
        public ProductBrand productBrand { get; set; }
        [Display(Name = "Gender")]
        public Gender gender { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Metrial { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }


    }
}