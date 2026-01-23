namespace Nager.Country.Currencies
{
    /// <summary>
    /// Dzd Currency
    /// </summary>
    public sealed class DzdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.ج.‏";

        /// <inheritdoc/>
        public string? Singular => "dinar";

        /// <inheritdoc/>
        public string? Plural => "dinar";

        /// <inheritdoc/>
        public string IsoCode => "DZD";

        /// <inheritdoc/>
        public string NumericCode => "012";

        /// <inheritdoc/>
        public string Name => "Algerian dinar";

        private DzdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new DzdCurrency();
    }
}
