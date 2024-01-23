using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class mypageModel : PageModel
    {
        public string AppValue { get; private set; }
        private readonly IConfiguration _myConfiguration;

        public mypageModel(IConfiguration configuration)
        {
            _myConfiguration = configuration;
            AppValue = _myConfiguration["AppValue"];
        }
        public void OnGet()
        {
        }
    }
}
