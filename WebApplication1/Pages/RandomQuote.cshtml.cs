using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace WebApplication1.Pages
{
    public class RandomQuoteModel : PageModel
    {
        public string Quote { get; set; }
        public string Author { get; set; }
        public void OnGet()
        {
            var quotes = LoadQuotes();
            var randomIndex = new Random().Next(0, quotes.Count);

            Quote = quotes[randomIndex].Quote;
            Author = quotes[randomIndex].Author;
        }

        private List<QuoteModel> LoadQuotes()
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "Quotes.json");

            if (!System.IO.File.Exists(jsonPath))
            {
                return new List<QuoteModel>();
            }

            var jsonContent = System.IO.File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<List<QuoteModel>>(jsonContent);
        }

        public class QuoteModel
        {
            public string Quote { get; set; }
            public string Author { get; set; }
        }
    }
}
