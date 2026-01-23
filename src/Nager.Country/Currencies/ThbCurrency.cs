namespace Nager.Country.Currencies
{
    /// <summary>
    /// Thb Currency
    /// </summary>
    public sealed class ThbCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "฿";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "THB";

        /// <inheritdoc/>
        public string NumericCode => "764";

        /// <inheritdoc/>
        public string Name => "Thai Baht";

        private ThbCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new ThbCurrency();
    }
}
