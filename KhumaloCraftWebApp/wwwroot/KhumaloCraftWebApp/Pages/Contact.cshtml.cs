using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhumaloCraftWebApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public void OnGet()
        {
            // Any server-side logic for the Contact Us Page can be added here
        }

        public IActionResult OnPost()
        {
            // Process the form submission (e.g., send an email)
            // Redirect to a Thank You page or return a message to the user
            return RedirectToPage("/ThankYou");
        }
    }
}
