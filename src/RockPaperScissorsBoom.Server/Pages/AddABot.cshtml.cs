using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RockPaperScissorsBoom.Server.Pages
{
    [Authorize]
    public class AddABot : PageModel
    {
        public void OnGet()
        {
        }
    }
}
