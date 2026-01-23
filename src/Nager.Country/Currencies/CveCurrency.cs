namespace Nager.Country.Currencies
{
    /// <summary>
    /// Cve Currency
    /// </summary>
    public sealed class CveCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "escudo";

        /// <inheritdoc/>
        public string? Plural => "escudo";

        /// <inheritdoc/>
        public string IsoCode => "CVE";

        /// <inheritdoc/>
        public string NumericCode => "132";

        /// <inheritdoc/>
        public string Name => "Cape Verdean escudo";

        private CveCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new CveCurrency();
    }
}
