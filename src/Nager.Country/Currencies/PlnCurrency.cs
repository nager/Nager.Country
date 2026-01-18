namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pln Currency
    /// </summary>
    public sealed class PlnCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "zł";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "PLN";

        /// <inheritdoc/>
        public string NumericCode => "985";

        /// <inheritdoc/>
        public string Name => "Polish Zloty";

        private PlnCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new PlnCurrency();
    }
}
