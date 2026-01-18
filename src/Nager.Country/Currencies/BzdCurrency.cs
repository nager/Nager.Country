namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bzd Currency
    /// </summary>
    public sealed class BzdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollars";

        /// <inheritdoc/>
        public string IsoCode => "BZD";

        /// <inheritdoc/>
        public string NumericCode => "084";

        /// <inheritdoc/>
        public string Name => "Belize dollar";

        private BzdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BzdCurrency();
    }
}
