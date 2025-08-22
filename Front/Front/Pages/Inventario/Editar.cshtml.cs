using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Front.Pages.Inventario
{
    public class EditarModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int IdInventario { get; set; }
        public void OnGet()
        {
        }
    }
}
