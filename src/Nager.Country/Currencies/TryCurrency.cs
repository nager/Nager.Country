namespace Nager.Country.Currencies
{
    public class TryCurrency : ICurrency
    {
        public string Symbol => "₺";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "TRY";

        public string NumericCode => null;

        public string Name => "Turkish Lira";
    }
}
