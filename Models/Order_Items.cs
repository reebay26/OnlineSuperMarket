using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineSuperMarket.Models
{
    public class Order_Items
    {
        [Key]
        public int OrderItem_id { get; set; }

        [Required]
        [ForeignKey("Order_Model")]
        public int Order_id { get; set; }
        public virtual Order_Model Order { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int Product_id { get; set; }
        public virtual Product_Model Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }
    }
}
