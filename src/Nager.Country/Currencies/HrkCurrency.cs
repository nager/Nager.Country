namespace Nager.Country.Currencies
{
    /// <summary>
    /// Hrk Currency
    /// </summary>
    public sealed class HrkCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "kn";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "HRK";

        /// <inheritdoc/>
        public string NumericCode => "191";

        /// <inheritdoc/>
        public string Name => "Croatian Kuna";

        private HrkCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new HrkCurrency();
    }
}
