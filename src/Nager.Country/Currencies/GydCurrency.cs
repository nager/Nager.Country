namespace Nager.Country.Currencies
{
    public class GydCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollar";

        public string IsoCode => "GYD";

        public string NumericCode => "328";

        public string Name => "Guyanese dollar";
    }
}
