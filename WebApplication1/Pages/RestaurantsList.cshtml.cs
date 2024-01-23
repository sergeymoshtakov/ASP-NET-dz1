using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages
{
    public class RestaurantsListModel : PageModel
    {
        public char RandomLetter { get; private set; }
        public List<Restaurant> Restaurants { get; private set; }
        public void OnGet()
        {
            Random random = new Random();
            int randomNumber = random.Next(65, 91);
            RandomLetter = (char)randomNumber;
            Restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Dominos",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Pizza Hut",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "McDonalds",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Burger King",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Subway",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Wendys",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Taco Bell",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Papa Johns",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Chick-fil-A",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Dunkin Donuts",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Starbucks",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Panera Bread",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Sonic Drive-In",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Dairy Queen",
                    Location = "Kolkata",
                    Description = "Fast Food"
                },
                new Restaurant()
                {
                    Name = "Arbys",
                    Location = "Kolkata",
                    Description = "Fast Food"
                }
            };
        }


    }
}
