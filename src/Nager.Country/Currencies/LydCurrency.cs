namespace Nager.Country.Currencies
{
    /// <summary>
    /// Lyd Currency
    /// </summary>
    public sealed class LydCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "د.ل.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "LYD";

        /// <inheritdoc/>
        public string NumericCode => "434";

        /// <inheritdoc/>
        public string Name => "Libyan Dinar";

        private LydCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new LydCurrency();
    }
}
