using TMPS_lab1.Builder.Domain;

namespace TMPS_lab1.Builder
{
    public static class BuilderExample
    {
        public static void StartExample()
        {
            var sosDeRosii = new Ingredient() { Name = "Sos de rosii" };
            var mozzarella = new Ingredient() { Name = "Mozzarella", Amount = "100g" };
            var sosBasilic = new Ingredient() { Name = "Sos basilic" };

            PizzaBuilder pizzaBuilder = new PizzaBuilder();

            Pizza margherita = pizzaBuilder
                .Type("Margherita ")
                .Ingredients(sosDeRosii)
                .Ingredients(mozzarella)
                .Ingredients(mozzarella)
                .Ingredients(sosBasilic)
                .Price(90)
                .PreparationTime(15)
                .Weight(430)
                .DoughType(DoughType.Subtire)
                .Build();
        }
    }
}