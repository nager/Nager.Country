namespace Nager.Country.Currencies
{
    /// <summary>
    /// Chf Currency
    /// </summary>
    public class ChfCurrency : ICurrency
    {
        ///<inheritdoc/>
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
