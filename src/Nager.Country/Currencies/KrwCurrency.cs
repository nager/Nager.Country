namespace Nager.Country.Currencies
{
    /// <summary>
    /// Krw Currency
    /// </summary>
    public sealed class KrwCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₩";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KRW";

        /// <inheritdoc/>
        public string NumericCode => "410";

        /// <inheritdoc/>
        public string Name => "South Korean Won";

        private KrwCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new KrwCurrency();
    }
}
