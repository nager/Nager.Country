namespace Nager.Country.Currencies
{
    public class TwdCurrency : ICurrency
    {
        public string Symbol => "NT$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "TWD";

        public string NumericCode => "901";

        public string Name => "New Taiwan Dollar";
    }
}
