using TMPS_lab1.Factory.Enums;
using TMPS_lab1.Factory.Interfaces;

namespace TMPS_lab1.Factory
{
    public static class FilterFunctionality
    {
        public static List<IProduct> FilterProducts(List<IProduct> products, List<ProductType> checkboxes)
        {
            var filteredResult = new List<IProduct>();

            foreach (var product in products)
            {
                if(checkboxes.Exists(t => t.ToString() == product.GetType().Name))
                {
                    filteredResult.Add(product);
                }
            }

            return filteredResult;
        }
    }
}