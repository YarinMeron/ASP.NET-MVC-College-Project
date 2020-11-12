using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenkinStore.Models
{
    public class Product
    {
        public bool sold { get; set; }
        public bool inCart { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(20, ErrorMessage = "Name can be only between 1-20 chars")]
        public string ProductName { get; set; }

      //  [Column(TypeName = "decimal(18, 2)")]
       [DisplayFormat(DataFormatString = "{0:C0}")]
        
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
        [Range(1, 100, ErrorMessage = "Can only be between 1 .. 100")]
        public int Quantity { get; set; }
        public string Metrial { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        public string CartId { get; set; }
      //  public int soldAmount  { get; set; }
    }
}