namespace Nager.Country.Currencies
{
    public class TryCurrency : ICurrency
    {
        public string Symbol => "₺";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "TRY";

        ///<inheritdoc/>
        public string NumericCode => "949";

        ///<inheritdoc/>
        public string Name => "Turkish Lira";
    }
}
