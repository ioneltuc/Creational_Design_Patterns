using TMPS_lab1.Builder.Domain;

namespace TMPS_lab1.Builder
{
    public class PizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();

        public PizzaBuilder Type(string type)
        {
            _pizza.Type = type;
            return this;
        }

        public PizzaBuilder Description(string description)
        {
            _pizza.Description = description;
            return this;
        }

        public PizzaBuilder Ingredients(Ingredient ingredient)
        {
            _pizza.Ingredients.Add(ingredient);
            return this;
        }

        public PizzaBuilder Price(double price)
        {
            _pizza.Price = price;
            return this;
        }

        public PizzaBuilder PreparationTime(int preparationTime)
        {
            _pizza.PreparationTime = preparationTime;
            return this;
        }

        public PizzaBuilder Weight(double weight)
        {
            _pizza.Weight = weight;
            return this;
        }

        public PizzaBuilder DoughType(DoughType doughType)
        {
            _pizza.DoughType = doughType;
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}