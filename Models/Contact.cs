using System.ComponentModel.DataAnnotations;

namespace OnlineSuperMarket.Models
{
    public class Contact
    {
        [Key]
        public int Contact_id { get; set; }
        [Required]
        public string Contact_name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Contact_email { get; set; }

        [Required]
        public string Contact_text { get; set; }
    }
}
