using TMPS_lab1.Factory.Enums;
using TMPS_lab1.Factory.Interfaces;

namespace TMPS_lab1.Factory.Factories
{
    public static class FactoryExample
    {
        public static void StartExample()
        {
            var factory = new ProductFactory();
            IProduct product1 = factory.CreateConcreteProduct(ProductType.TopProduct, 1, "Jeans", "Blue", 420);
            IProduct product2 = factory.CreateConcreteProduct(ProductType.TopProduct, 2, "Sport pants", "Black", 300);
            IProduct product3 = factory.CreateConcreteProduct(ProductType.BottomProduct, 3, "T-Shirt", null, 250);
            IProduct product4 = factory.CreateConcreteProduct(ProductType.BottomProduct, 4, "Shirt", "White", 359);
            IProduct product5 = factory.CreateConcreteProduct(ProductType.Footwear, 5, "Shoes", "Casual", 820);
            IProduct product6 = factory.CreateConcreteProduct(ProductType.Footwear, 6, "Trainers", "For running", 1200);
            IProduct product7 = factory.CreateConcreteProduct(ProductType.Accessory, 7, "Ring", "Gold", 3200);

            var products = new List<IProduct>()
            {
                product1, product2, product3, product4, product5, product6, product7
            };

            List<IProduct> filteredProducts = FilterFunctionality
                .FilterProducts(products, new List<ProductType>() { ProductType.Accessory, ProductType.Footwear });

            Console.WriteLine(filteredProducts.Count);
        }
    }
}