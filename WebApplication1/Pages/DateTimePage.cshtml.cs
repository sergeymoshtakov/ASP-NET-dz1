using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class DateTimePageModel : PageModel
    {
        public string CurrentDateTime { get; private set; }
        public void OnGet()
        {
            CurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
