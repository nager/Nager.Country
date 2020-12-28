namespace Nager.Country.Currencies
{
    public class GbpCurrency : ICurrency
    {
        public string Symbol => "£";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "GBP";

        public string NumericCode => "826";

        public string Name => "British Pound";
    }
}
