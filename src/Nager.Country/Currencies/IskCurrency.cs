namespace Nager.Country.Currencies
{
    /// <summary>
    /// Isk Currency
    /// </summary>
    public sealed class IskCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "kr";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "ISK";

        /// <inheritdoc/>
        public string NumericCode => "352";

        /// <inheritdoc/>
        public string Name => "Icelandic Króna";

        private IskCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new IskCurrency();
    }
}
