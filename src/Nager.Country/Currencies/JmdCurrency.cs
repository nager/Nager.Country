namespace Nager.Country.Currencies
{
    public class JmdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "JMD";

        public string NumericCode => "388";

        public string Name => "Jamaican Dollar";
    }
}
