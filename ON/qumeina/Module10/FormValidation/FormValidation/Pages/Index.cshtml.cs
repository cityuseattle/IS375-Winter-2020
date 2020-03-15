using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FormValidation.Models;

namespace FormValidation.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Account account { get; set; }
        public void OnGet()
        {
            account = new Account();
        }

        public IActionResult OnPost(Account account)
        {
            if (account.Username != null && account.Username.Equals("abc"))
            {
                ModelState.AddModelError("account.Username", "Username Already Exists");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            } else
            {
                return RedirectToPage("Success");
            }
        }
    }
}
