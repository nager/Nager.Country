namespace Nager.Country.Currencies
{
    public class AedCurrency : ICurrency
    {
        public string Symbol => "د.إ";

        public string Singular => "dirham";

        public string Plural => null;

        public string IsoCode => "AED";

        public string NumericCode => "784";

        public string Name => "United Arab Emirates dirham";
    }
}
