namespace Nager.Country.Currencies
{
    public class TryCurrency : ICurrency
    {
        public string Symbol => "₺";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "TRY";

        public string NumericCode => "949";

        public string Name => "Turkish Lira";
    }
}
