namespace TMPS_lab1.Singleton
{
    public class OrderInfo : Entity
    {
        public Courier Courier { get; set; }
        public Order Order { get; set; }
    }
}