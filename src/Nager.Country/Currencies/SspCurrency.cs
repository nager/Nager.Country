namespace Nager.Country.Currencies
{
    /// <summary>
    /// Ssp Currency
    /// </summary>
    public sealed class SspCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "SS�";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SSP";

        /// <inheritdoc/>
        public string NumericCode => "728";

        /// <inheritdoc/>
        public string Name => "South Sudanese pound";

        private SspCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new SspCurrency();
    }
}
