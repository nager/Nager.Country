namespace Nager.Country.Currencies
{
    /// <summary>
    /// Lbp Currency
    /// </summary>
    public sealed class LbpCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "ل.ل.‏";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "LBP";

        /// <inheritdoc/>
        public string NumericCode => "422";

        /// <inheritdoc/>
        public string Name => "Lebanese Pound";

        private LbpCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new LbpCurrency();
    }
}
