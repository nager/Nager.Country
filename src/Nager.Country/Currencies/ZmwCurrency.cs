namespace Nager.Country.Currencies
{
    public class ZmwCurrency : ICurrency
    {
        public string Symbol => "K";

        public string Singular => "kwacha";

        public string Plural => null;

        public string IsoCode => "ZMW";

        public string NumericCode => "967";

        public string Name => "Zambian kwacha";
    }
}
