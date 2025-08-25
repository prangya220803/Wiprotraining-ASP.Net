using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;


namespace Core_MVC_Wipro_demo1.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}
