namespace Nager.Country.Currencies
{
    /// <summary>
    /// Ttd Currency
    /// </summary>
    public sealed class TtdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "TTD";

        /// <inheritdoc/>
        public string NumericCode => "780";

        /// <inheritdoc/>
        public string Name => "Trinidad and Tobago Dollar";

        private TtdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new TtdCurrency();
    }
}
