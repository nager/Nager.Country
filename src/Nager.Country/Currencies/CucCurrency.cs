namespace Nager.Country.Currencies
{
    /// <summary>
    /// Cuc Currency
    /// </summary>
    public sealed class CucCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "peso";

        /// <inheritdoc/>
        public string? Plural => "peso";

        /// <inheritdoc/>
        public string IsoCode => "CUC";

        /// <inheritdoc/>
        public string NumericCode => "931";

        /// <inheritdoc/>
        public string Name => "Cuban convertible peso";

        private CucCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new CucCurrency();
    }
}
