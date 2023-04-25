namespace TMPS_lab1.Singleton
{
    public class Order : Entity
    {
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}