namespace TMPS_lab1.Singleton
{
    public static class SingletonExample
    {
        public static void StartExample()
        {
            var courier1 = new Courier() { Id = 1, FirstName = "Rick", LastName = "Novak", Age = 32 };
            var courier2 = new Courier() { Id = 2, FirstName = "Jeff", LastName = "Johnson", Age = 24 };
            var courier3 = new Courier() { Id = 3, FirstName = "Tom", LastName = "Taylor", Age = 45 };
            CouriersList.Couriers.Add(courier1);
            CouriersList.Couriers.Add(courier2);
            CouriersList.Couriers.Add(courier3);

            var product1 = new Product() { Id = 1, Name = "Shoes", Description = "Black", Price = 40 };
            var product2 = new Product() { Id = 2, Name = "T-Shirt", Description = "White oversized", Price = 20 };
            var product3 = new Product() { Id = 3, Name = "Gloves", Description = "Black", Price = 5 };
            var product4 = new Product() { Id = 4, Name = "Glasses", Description = "For sun", Price = 12 };
            var product5 = new Product() { Id = 5, Name = "Trainers", Description = "For running", Price = 55 };

            ParcelManager parcelManager = ParcelManager.Instance;

            var order1 = new Order() { Id = 1 };
            order1.Products.Add(product1);
            order1.Products.Add(product2);
            order1.Products.Add(product3);
            parcelManager.AssignParcel(order1);

            var order2 = new Order() { Id = 2 };
            order2.Products.Add(product1);
            parcelManager.AssignParcel(order2);

            var order3 = new Order() { Id = 3 };
            order3.Products.Add(product3);
            order3.Products.Add(product4);
            parcelManager.AssignParcel(order3);

            var order4 = new Order() { Id = 4 };
            order4.Products.Add(product5);
            order4.Products.Add(product5);
            order4.Products.Add(product2);
            order4.Products.Add(product2);
            order4.Products.Add(product3);
            parcelManager.AssignParcel(order4);

            var order5 = new Order() { Id = 5 };
            order5.Products.Add(product2);
            parcelManager.AssignParcel(order5);

            parcelManager.ShowParcelListInfo();

            Console.WriteLine(new string('*', 50) + "\n");

            parcelManager.MarkParcelAsArrived(order1);
            parcelManager.MarkParcelAsArrived(order3);

            var order6 = new Order() { Id = 6 };
            order6.Products.Add(product1);
            order6.Products.Add(product2);
            order6.Products.Add(product4);
            parcelManager.AssignParcel(order6);

            parcelManager.ShowParcelListInfo();
        }
    }
}