using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Front.Pages.Resenas
{
    public class CrearModel : PageModel
    {
        public int IdUsuario { get; set; }
        public void OnGet()
        {
            IdUsuario = int.Parse(User.FindFirst("id_usuario")?.Value ?? "0");

            foreach (var claim in User.Claims)
            {
                Console.WriteLine($"Claim type: {claim.Type}, value: {claim.Value}");
            }
        }
    }
}
