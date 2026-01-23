namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bif Currency
    /// </summary>
    public sealed class BifCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "FBu";

        /// <inheritdoc/>
        public string? Singular => "franc";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "BIF";

        /// <inheritdoc/>
        public string NumericCode => "108";

        /// <inheritdoc/>
        public string Name => "Burundian franc";

        private BifCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BifCurrency();
    }
}
