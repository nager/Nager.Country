namespace Nager.Country.Currencies
{
    public class HkdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "HKD";

        public string NumericCode => "344";

        public string Name => "Hong Kong Dollar";
    }
}
