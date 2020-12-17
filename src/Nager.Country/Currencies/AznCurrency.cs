namespace Nager.Country.Currencies
{
    public class AznCurrency : ICurrency
    {
        public string Symbol => "₼";

        public string Singular => "manat";

        public string Plural => null;

        public string IsoCode => "AZN";

        public string NumericCode => "944";

        public string Name => "Azerbaijani manat";
    }
}
