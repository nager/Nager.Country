namespace Nager.Country.Currencies
{
    /// <summary>
    /// Lak Currency
    /// </summary>
    public sealed class LakCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₭";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "LAK";

        /// <inheritdoc/>
        public string NumericCode => "418";

        /// <inheritdoc/>
        public string Name => "Laotian Kip";

        private LakCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new LakCurrency();
    }
}
