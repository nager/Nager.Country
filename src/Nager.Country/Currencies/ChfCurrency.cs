namespace Nager.Country.Currencies
{
    public class ChfCurrency : ICurrency
    {
        public string Symbol => "CHF";

        public string Singular => "franc";

        public string Plural => "francs";

        public string IsoCode => "CHF";

        public string NumericCode => "756";

        public string Name => "Swiss franc";
    }
}
