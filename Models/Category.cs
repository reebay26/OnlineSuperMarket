using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineSuperMarket.Models
{
    public class Category
    {
        [Key]
     
        public int category_id { get; set; }

        [Required]
        public required string category_name { get; set; }
        [Required]
        public required string category_desc { get; set; }
      
    }
}

