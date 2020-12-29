namespace Nager.Country.Currencies
{
    public class VndCurrency : ICurrency
    {
        public string Symbol => "₫";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "VND";

        public string NumericCode => "704";

        public string Name => "Vietnamese Dong";
    }
}
