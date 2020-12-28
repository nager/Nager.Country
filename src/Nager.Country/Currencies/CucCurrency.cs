namespace Nager.Country.Currencies
{
    public class CucCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "peso";

        public string Plural => "peso";

        public string IsoCode => "CUC";

        public string NumericCode => "931";

        public string Name => "Cuban convertible peso";
    }
}
