using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineSuperMarket.Models
{
    public class Product_Model
    {
        [Key]
        public int Product_id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]  // Correct way to define FK
        public int product_category { get; set; }

        public virtual Category Category { get; set; }

      
        [ForeignKey(nameof(brand))]
        public int? product_brand { get; set; }

        public virtual Brand brand { get; set; }

        [Required]
        public int ProductPrice { get; set; }

        [Required]
        public int ProductQuantity { get; set; }

        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductImage { get; set; }

    }

}
