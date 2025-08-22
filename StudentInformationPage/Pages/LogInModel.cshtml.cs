using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentInformationPage.Pages
{
    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LogInModelModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
