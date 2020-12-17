namespace Nager.Country.Currencies
{
    public class BsdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "dollar";

        public string Plural => "dollars";

        public string IsoCode => "BSD";

        public string NumericCode => "044";

        public string Name => "Bahamian dollar";
    }
}
