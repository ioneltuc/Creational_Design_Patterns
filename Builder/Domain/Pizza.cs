namespace TMPS_lab1.Builder.Domain
{
    public class Pizza
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set;} = new List<Ingredient>();
        public double Price { get; set; }
        public int PreparationTime { get; set; }
        public double Weight { get; set; }
        public DoughType DoughType { get; set; }
    }
}