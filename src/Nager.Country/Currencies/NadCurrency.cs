namespace Nager.Country.Currencies
{
    public class NadCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "NAD";

        public string NumericCode => "516";

        public string Name => "Namibian dollar";
    }
}
