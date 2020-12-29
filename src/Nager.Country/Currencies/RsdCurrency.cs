namespace Nager.Country.Currencies
{
    public class RsdCurrency : ICurrency
    {
        public string Symbol => "дин.";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "RSD";

        public string NumericCode => "941";

        public string Name => "Serbian Dinar";
    }
}
