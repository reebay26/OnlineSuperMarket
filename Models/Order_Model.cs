using System.ComponentModel.DataAnnotations;

namespace OnlineSuperMarket.Models
{
    public class Order_Model
    {
        [Key]
        public int Order_id { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Customer_Email { get; set; }
        public virtual List<Order_Items> Order_Items { get; set; } = new List<Order_Items>();
    }
}
