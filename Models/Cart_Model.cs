using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineSuperMarket.Models
{
    public class Cart_Model
    {
        [Key]
        public int CartId { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int User_id { get; set; }  

        [Required]
        [ForeignKey(nameof(Product))]
        public int Product_id { get; set; }

        public virtual Register_model User { get; set; } 
        public virtual Product_Model Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int TotalPrice { get; set; }
    }
}
