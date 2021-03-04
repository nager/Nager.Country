namespace Nager.Country.Currencies
{
    public class TmtCurrency : ICurrency
    {
        public string Symbol => "m.";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "TMT";

        ///<inheritdoc/>
        public string NumericCode => "934";

        ///<inheritdoc/>
        public string Name => "Turkmenistani Manat";
    }
}
