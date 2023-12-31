using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RiHack_RitehKromanjonci.Data;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using RiHack_RitehKromanjonci.Models;

namespace RiHack_RitehKromanjonci.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _context;


        public RegisterModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        [EmailAddress(ErrorMessage = "Neispravan email.")]
        [Required(ErrorMessage = "Potrebno je upisati email.")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Potrebno je upisati lozinku.")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Potrebno je upisati username.")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Potrebno je upisati OIB.")]
        public string OIB { get; set; }

        public string info = string.Empty;

        public async Task<ActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = new User
            {
                Email = Email,
                Password = Password,
                Username = Username,
                OIB = OIB
            };

            info = "Provjeravanje validnosti OIB-a";
            await CheckOIBValidity();
            info = string.Empty;


            _context.Users.Add(user);

            await _context.SaveChangesAsync();


            // redirectati korisnika na drugi page gdje moze upisati taj access code
            return Redirect("./login");
        }
        async Task CheckOIBValidity()
        {
            //feature za dodati :)
            await Task.Delay(10000);
        }
    }
    
}
