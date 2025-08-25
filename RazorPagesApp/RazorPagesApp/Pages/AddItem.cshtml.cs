using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public string? NewItem { get; set; }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrWhiteSpace(NewItem))
            {
                ItemsModel.AddItem(NewItem);  // call static helper
            }
            return RedirectToPage("Items");
        }
    }
}