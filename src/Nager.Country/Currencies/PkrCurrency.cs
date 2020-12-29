namespace Nager.Country.Currencies
{
    public class PkrCurrency : ICurrency
    {
        public string Symbol => "Rs";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "PKR";

        public string NumericCode => "586";

        public string Name => "Pakistani Rupee";
    }
}
