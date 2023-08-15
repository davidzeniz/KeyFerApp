using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KeyFerApp.Pages.Dashboard
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            Console.WriteLine("--------------------- OnPost -----------------------");

            return Page();
        }
    }
}
