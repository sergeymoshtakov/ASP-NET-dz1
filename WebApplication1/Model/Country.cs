namespace WebApplication1.Model
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string CountryCode { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public override string ToString()
        {
            return $"Name:  {Name}" +
                $"\nCapital:   {Capital}" +
                $"\nCountry Code:    {CountryCode}" +
                $"\nArea:  {Area}" +
                $"\nPopulation:    {Population}";
        }
    }
}
