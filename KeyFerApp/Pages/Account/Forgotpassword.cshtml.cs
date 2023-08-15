using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KeyFerApp.Pages.Account
{
    public class ForgotpasswordModel : PageModel
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
