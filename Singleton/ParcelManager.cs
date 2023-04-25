namespace TMPS_lab1.Singleton
{
    public sealed class ParcelManager
    {
        private static readonly Lazy<ParcelManager> _instance = new Lazy<ParcelManager>(() => new ParcelManager());

        public static ParcelManager Instance
        { get { return _instance.Value; } }

        private List<OrderInfo> _orders = new List<OrderInfo>();
        private int courierIndex = 0;

        private ParcelManager()
        {
        }

        public void AssignParcel(Order order)
        {
            var newOrderInfo = new OrderInfo();
            newOrderInfo.Id = order.Id;
            newOrderInfo.Order = order;
            newOrderInfo.Courier = CouriersList.Couriers[courierIndex];

            _orders.Add(newOrderInfo);

            courierIndex++;

            if (courierIndex >= CouriersList.Couriers.Count)
            {
                courierIndex = 0;
            }
        }

        public void ShowParcelListInfo()
        {
            foreach (var order in _orders)
            {
                Console.WriteLine($"Order ID: {order.Id}");
                Console.WriteLine($"Courier: {order.Courier.Id} - {order.Courier.FirstName} {order.Courier.LastName}\n");
                Console.WriteLine("Order info:");
                foreach (var product in order.Order.Products)
                {
                    Console.WriteLine($"\tName: {product.Name}");
                    Console.WriteLine($"\tName: {product.Description}");
                    Console.WriteLine($"\t\tName: {product.Price}\n");
                }
            }
        }

        public void MarkParcelAsArrived(Order order)
        {
            _orders.RemoveAll(o => o.Order.Id == order.Id);
        }
    }
}