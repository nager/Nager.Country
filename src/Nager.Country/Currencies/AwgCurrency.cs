namespace Nager.Country.Currencies
{
    /// <summary>
    /// Awg Currency
    /// </summary>
    public sealed class AwgCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Afl";

        /// <inheritdoc/>
        public string? Singular => "florin";

        /// <inheritdoc/>
        public string? Plural => "florin";

        /// <inheritdoc/>
        public string IsoCode => "AWG";

        /// <inheritdoc/>
        public string NumericCode => "533";

        /// <inheritdoc/>
        public string Name => "Aruban florin";

        private AwgCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new AwgCurrency();
    }
}
