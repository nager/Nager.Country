namespace Nager.Country.Currencies
{
    public class BifCurrency : ICurrency
    {
        public string Symbol => "FBu";

        public string Singular => "franc";

        public string Plural => null;

        public string IsoCode => "BIF";

        public string NumericCode => "108";

        public string Name => "Burundian franc";
    }
}
