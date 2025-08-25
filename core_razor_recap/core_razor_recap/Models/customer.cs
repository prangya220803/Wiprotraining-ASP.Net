using Microsoft.AspNetCore.Mvc;

namespace core_razor_recap.Models
{
    public class customer
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            Message = $"{Name}, information will be sent to {Email}";
        }
    }
}
