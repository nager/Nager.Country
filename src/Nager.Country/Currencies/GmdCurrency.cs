namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gmd Currency
    /// </summary>
    public sealed class GmdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "D";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "GMD";

        /// <inheritdoc/>
        public string NumericCode => "270";

        /// <inheritdoc/>
        public string Name => "Gambian dalasi";

        private GmdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new GmdCurrency();
    }
}
