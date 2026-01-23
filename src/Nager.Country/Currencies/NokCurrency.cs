namespace Nager.Country.Currencies
{
    /// <summary>
    /// Nok Currency
    /// </summary>
    public sealed class NokCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "kr";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "NOK";

        /// <inheritdoc/>
        public string NumericCode => "578";

        /// <inheritdoc/>
        public string Name => "Norwegian Krone";

        private NokCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new NokCurrency();
    }
}
