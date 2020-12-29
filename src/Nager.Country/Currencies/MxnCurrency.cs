namespace Nager.Country.Currencies
{
    public class MxnCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "MXN";

        public string NumericCode => "484";

        public string Name => "Mexican Peso";
    }
}
