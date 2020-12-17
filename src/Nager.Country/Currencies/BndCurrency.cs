namespace Nager.Country.Currencies
{
    public class BndCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "BND";

        public string NumericCode => "096";

        public string Name => "Brunei dollar";
    }
}
