namespace Nager.Country.Currencies
{
    public class SbdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "SBD";

        public string NumericCode => "090";

        public string Name => "Solomon Islands dollar";
    }
}
