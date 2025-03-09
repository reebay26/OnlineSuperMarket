

using System.ComponentModel.DataAnnotations;

namespace OnlineSuperMarket.Models
{
    public class Register_model
    {
        [Key]
        public int User_id { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        public required string User_name { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public required string User_email { get; set; }
        [Required(ErrorMessage = "Contact is required")]

        public required string User_contact { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string User_password { get; set; }
        public string User_role { get; set; } = "customer";
        public string? ResetToken { get; set; } 
        public DateTime? ResetTokenExpiry { get; set; }
    }
}
