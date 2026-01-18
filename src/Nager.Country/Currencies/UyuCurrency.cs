namespace Nager.Country.Currencies
{
    /// <summary>
    /// Uyu Currency
    /// </summary>
    public sealed class UyuCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "UYU";

        /// <inheritdoc/>
        public string NumericCode => "858";

        /// <inheritdoc/>
        public string Name => "Uruguayan Peso";

        private UyuCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new UyuCurrency();
    }
}
