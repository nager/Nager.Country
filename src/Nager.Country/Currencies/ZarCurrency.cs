namespace Nager.Country.Currencies
{
    public class ZarCurrency : ICurrency
    {
        public string Symbol => "R";

        public string Singular => "rand";

        public string Plural => "rand";

        public string IsoCode => "ZAR";

        public string NumericCode => "710";

        public string Name => "South African Rand";
    }
}
