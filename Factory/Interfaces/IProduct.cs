namespace TMPS_lab1.Factory.Interfaces
{
    public interface IProduct
    {
        double GetPriceInEuros(double euroExchangeRate);

        double GetPriceInDollars(double dollarExchangeRate);
    }
}