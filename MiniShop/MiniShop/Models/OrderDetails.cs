using System.ComponentModel.DataAnnotations;

namespace MiniShop.Models
{
    public class OrderDetails
    {
        [Required] public string FullName { get; set; } = "";
        [Required] public string Address { get; set; } = "";
        [Required, Phone] public string Phone { get; set; } = "";
    }
}
