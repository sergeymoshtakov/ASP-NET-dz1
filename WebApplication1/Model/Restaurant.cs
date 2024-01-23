namespace WebApplication1.Model
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Name:  {Name}" +
                $"\nLocation:   {Location}" +
                $"\nDescription:    {Description}";
        }
    }
}
