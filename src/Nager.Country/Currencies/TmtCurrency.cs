namespace Nager.Country.Currencies
{
    /// <summary>
    /// Tmt Currency
    /// </summary>
    public sealed class TmtCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "m.";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "TMT";

        /// <inheritdoc/>
        public string NumericCode => "934";

        /// <inheritdoc/>
        public string Name => "Turkmenistani Manat";

        private TmtCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new TmtCurrency();
    }
}
