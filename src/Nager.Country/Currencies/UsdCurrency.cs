namespace Nager.Country.Currencies
{
    /// <summary>
    /// Usd Currency
    /// </summary>
    public sealed class UsdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "USD";

        /// <inheritdoc/>
        public string NumericCode => "840";

        /// <inheritdoc/>
        public string Name => "US Dollar";

        private UsdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new UsdCurrency();
    }
}
