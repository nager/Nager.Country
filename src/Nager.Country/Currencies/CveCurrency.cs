namespace Nager.Country.Currencies
{
    public class CveCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => "escudo";

        public string Plural => "escudo";

        public string IsoCode => "CVE";

        public string NumericCode => "132";

        public string Name => "Cape Verdean escudo";
    }
}
