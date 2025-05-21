namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gbp Currency
    /// </summary>
    public class GbpCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string Symbol => "£";

        /// <inheritdoc/>
        public string Singular => null;

        /// <inheritdoc/>
        public string Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "GBP";

        /// <inheritdoc/>
        public string NumericCode => "826";

        /// <inheritdoc/>
        public string Name => "British Pound";
    }
}
