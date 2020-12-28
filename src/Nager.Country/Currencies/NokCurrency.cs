namespace Nager.Country.Currencies
{
    public class NokCurrency : ICurrency
    {
        public string Symbol => "kr";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "NOK";

        public string NumericCode => null;

        public string Name => "Norwegian Krone";
    }
}
