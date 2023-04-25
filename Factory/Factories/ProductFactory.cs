using TMPS_lab1.Factory.Domain;
using TMPS_lab1.Factory.Enums;
using TMPS_lab1.Factory.Interfaces;

namespace TMPS_lab1.Factory
{
    public class ProductFactory
    {
        public IProduct CreateConcreteProduct(ProductType type, int id, string name, string description, double price)
        {
            switch (type)
            {
                case ProductType.TopProduct:
                    return new TopProduct(id, name, description, price);

                case ProductType.BottomProduct:
                    return new BottomProduct(id, name, description, price);

                case ProductType.Footwear:
                    return new Footwear(id, name, description, price);

                case ProductType.Accessory:
                    return new Accessory(id, name, description, price);

                default:
                    return null;
            }
        }
    }
}