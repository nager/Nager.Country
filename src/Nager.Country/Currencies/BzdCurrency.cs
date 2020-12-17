namespace Nager.Country.Currencies
{
    public class BzdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "BZD";

        public string NumericCode => "084";

        public string Name => "Belize dollar";
    }
}
