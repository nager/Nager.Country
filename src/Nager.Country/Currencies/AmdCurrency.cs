namespace Nager.Country.Currencies
{
    /// <summary>
    /// Armenian dram
    /// </summary>
    public sealed class AmdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "֏";

        /// <inheritdoc/>
        public string? Singular => "dram";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "AMD";

        /// <inheritdoc/>
        public string NumericCode => "051";

        /// <inheritdoc/>
        public string Name => "Armenian dram";

        private AmdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new AmdCurrency();
    }
}
