namespace Nager.Country.Currencies
{
    public class EurCurrency : ICurrency
    {
        public string Symbol => "€";

        public string Singular => "euro";

        public string Plural => "euro";

        public string IsoCode => "EUR";

        public string NumericCode => "978";

        public string Name => "Euro";
    }
}
