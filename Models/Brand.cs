using System.ComponentModel.DataAnnotations;

namespace OnlineSuperMarket.Models
{
    public class Brand
    {

        [Key]
        public int brand_id { get; set; }
        [Required]
        public required string brand_name { get; set; }
        [Required]
        public required string brand_desc { get; set; }

    }
}