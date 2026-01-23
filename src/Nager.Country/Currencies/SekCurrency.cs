namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sek Currency
    /// </summary>
    public sealed class SekCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "kr";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "SEK";

        /// <inheritdoc/>
        public string NumericCode => "752";

        /// <inheritdoc/>
        public string Name => "Swedish Krona";

        private SekCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new SekCurrency();
    }
}
