using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KeyFerApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        

        public IActionResult OnPost()
        {
           

                  return RedirectToPage("/Dashboard/Index");

         

        }    
    }
}
