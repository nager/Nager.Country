namespace Nager.Country.Currencies
{
    public class SrdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "SRD";

        public string NumericCode => "968";

        public string Name => "Surinamese dollar";
    }
}
