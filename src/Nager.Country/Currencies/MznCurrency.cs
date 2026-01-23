namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mzn Currency
    /// </summary>
    public sealed class MznCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "MT";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MZN";

        /// <inheritdoc/>
        public string NumericCode => "943";

        /// <inheritdoc/>
        public string Name => "Mozambican metical";

        private MznCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MznCurrency();
    }
}
