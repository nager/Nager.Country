namespace Nager.Country.Currencies
{
    public class CupCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "peso";

        public string Plural => "peso";

        public string IsoCode => "CUP";

        public string NumericCode => "192";

        public string Name => "Cuban peso";
    }
}
