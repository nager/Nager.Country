namespace Nager.Country.Currencies
{
    /// <summary>
    /// Wst Currency
    /// </summary>
    public sealed class WstCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "WS$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "WST";

        /// <inheritdoc/>
        public string NumericCode => "882";

        /// <inheritdoc/>
        public string Name => "Samoan tala";

        private WstCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new WstCurrency();
    }
}
