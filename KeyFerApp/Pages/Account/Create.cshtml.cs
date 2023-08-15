using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KeyFerApp.Pages.Account
{
    public class CreateModel : PageModel
    {
     
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/Account/Login");
        }
    }
}
