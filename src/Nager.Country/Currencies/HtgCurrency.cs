namespace Nager.Country.Currencies
{
    /// <summary>
    /// Htg Currency
    /// </summary>
    public sealed class HtgCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "G";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "HTG";

        /// <inheritdoc/>
        public string NumericCode => "332";

        /// <inheritdoc/>
        public string Name => "Haitian Gourde";

        private HtgCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new HtgCurrency();
    }
}
