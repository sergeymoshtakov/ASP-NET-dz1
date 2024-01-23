using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages
{
    public class CountriesModel : PageModel
    {
        public List<Country> Countries { get; private set; }
        public void OnGet()
        {
            Countries = new List<Country>
            {
                new Country
                {
                    Name = "Ukraine",
                    Capital = "Kyiv",
                    CountryCode = "UA",
                    Area = 603500,
                    Population = 41902416
                },
                new Country
                {
                    Name = "United States",
                    Capital = "Washington, D.C.",
                    CountryCode = "US",
                    Area = 9833517,
                    Population = 331002651
                },
                new Country
                {
                    Name = "India",
                    Capital = "New Delhi",
                    CountryCode = "IN",
                    Area = 3287263,
                    Population = 1380004385
                }
            };
        }
    }
}
