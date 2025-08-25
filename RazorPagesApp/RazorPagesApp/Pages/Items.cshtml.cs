using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RazorPagesApp.Pages
{
    public class ItemsModel : PageModel
    {
        // instance property, not static
        public List<string> ItemList { get; set; } = new List<string>();

        // temporarily store items in memory (for demo)
        private static List<string> AllItems = new List<string>();

        public void OnGet()
        {
            ItemList = AllItems;
        }

        // helper method to add item
        public static void AddItem(string item)
        {
            AllItems.Add(item);
        }
    }
}