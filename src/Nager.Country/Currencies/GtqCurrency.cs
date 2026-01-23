namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gtq Currency
    /// </summary>
    public sealed class GtqCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Q";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "GTQ";

        /// <inheritdoc/>
        public string NumericCode => "320";

        /// <inheritdoc/>
        public string Name => "Guatemalan Quetzal";

        private GtqCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new GtqCurrency();
    }
}
