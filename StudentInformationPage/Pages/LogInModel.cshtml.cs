using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace StudentInformationPage.Pages
{
    public class Credential
    {
        [Required(ErrorMessage = "Username not valid.")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password not valid.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    
    }

    public class LogInModelModel : PageModel
    {
        public Credential Credential { get; set; } = new Credential();


        public IActionResult OnPost()
        {
            if(Credential.Username == "Admin" && Credential.Password == "admin123")
            {
                return RedirectToPage("/index");

            }
            return Page();

        }
    }
}
