namespace Nager.Country.Currencies
{
    /// <summary>
    /// Tnd Currency
    /// </summary>
    public sealed class TndCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.ت.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "TND";

        /// <inheritdoc/>
        public string NumericCode => "788";

        /// <inheritdoc/>
        public string Name => "Tunisian Dinar";

        private TndCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new TndCurrency();
    }
}
