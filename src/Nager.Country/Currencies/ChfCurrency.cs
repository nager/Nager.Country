namespace Nager.Country.Currencies
{
    public class ChfCurrency : ICurrency
    {
        public string Symbol => "CHF";

        ///<inheritdoc/>
        public string Singular => "franc";

        ///<inheritdoc/>
        public string Plural => "francs";

        ///<inheritdoc/>
        public string IsoCode => "CHF";

        ///<inheritdoc/>
        public string NumericCode => "756";

        ///<inheritdoc/>
        public string Name => "Swiss franc";
    }
}
