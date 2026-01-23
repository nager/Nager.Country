namespace Nager.Country.Currencies
{
    /// <summary>
    /// Twd Currency
    /// </summary>
    public sealed class TwdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "NT$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "TWD";

        /// <inheritdoc/>
        public string NumericCode => "901";

        /// <inheritdoc/>
        public string Name => "New Taiwan Dollar";

        private TwdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new TwdCurrency();
    }
}
