using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.CompilerServices;
using WebApplication1.Model;

namespace WebApplication1.Pages
{
    public class RestaurantInfoModel : PageModel
    {
        private Restaurant rest; 
        public string Info { get; set; }
        public void OnGet()
        {
            rest = new Restaurant()
            {
                Name = "KFC",
                Location = "Kolkata",
                Description = "Fast Food"
            };
            Info = rest.ToString();
        }
    }
}
