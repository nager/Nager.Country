namespace Nager.Country.Currencies
{
    /// <summary>
    /// Lrd Currency
    /// </summary>
    public sealed class LrdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "LRD";

        /// <inheritdoc/>
        public string NumericCode => "430";

        /// <inheritdoc/>
        public string Name => "Liberian dollar";

        private LrdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new LrdCurrency();
    }
}
