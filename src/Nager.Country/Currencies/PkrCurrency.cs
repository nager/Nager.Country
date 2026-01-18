namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pkr Currency
    /// </summary>
    public sealed class PkrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Rs";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "PKR";

        /// <inheritdoc/>
        public string NumericCode => "586";

        /// <inheritdoc/>
        public string Name => "Pakistani Rupee";

        private PkrCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new PkrCurrency();
    }
}
