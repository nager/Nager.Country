namespace Nager.Country.Currencies
{
    /// <summary>
    /// Top Currency
    /// </summary>
    public sealed class TopCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "T$";

        /// <inheritdoc/>
        public string? Singular => "paʻanga";

        /// <inheritdoc/>
        public string? Plural => "paʻanga";

        /// <inheritdoc/>
        public string IsoCode => "TOP";

        /// <inheritdoc/>
        public string NumericCode => "776";

        /// <inheritdoc/>
        public string Name => "Tongan paʻanga";

        private TopCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new TopCurrency();
    }
}
