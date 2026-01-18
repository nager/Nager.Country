namespace Nager.Country.Currencies
{
    /// <summary>
    /// Azn Currency
    /// </summary>
    public sealed class AznCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₼";

        /// <inheritdoc/>
        public string? Singular => "manat";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "AZN";

        /// <inheritdoc/>
        public string NumericCode => "944";

        /// <inheritdoc/>
        public string Name => "Azerbaijani manat";

        private AznCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new AznCurrency();
    }
}
