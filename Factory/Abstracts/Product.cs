using TMPS_lab1.Factory.Interfaces;

namespace TMPS_lab1.Factory.Abstracts
{
    public abstract class Product : Entity, IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public double GetPriceInDollars(double dollarExchangeRate)
        {
            return Math.Round(Price / dollarExchangeRate, 2);
        }

        public double GetPriceInEuros(double euroExchangeRate)
        {
            return Math.Round(Price / euroExchangeRate, 2);
        }
    }
}