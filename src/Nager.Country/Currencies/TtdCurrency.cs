namespace Nager.Country.Currencies
{
    public class TtdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "TTD";

        public string NumericCode => "780";

        public string Name => "Trinidad and Tobago Dollar";
    }
}
