namespace Nager.Country.Currencies
{
    public class KydCurrency : ICurrency
    {
        public string Symbol => "$";
        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "KYD";

        public string NumericCode => "136";

        public string Name => "Cayman Islands dollar";
    }
}
