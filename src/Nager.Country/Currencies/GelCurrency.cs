namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gel Currency
    /// </summary>
    public sealed class GelCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₾";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "GEL";

        /// <inheritdoc/>
        public string NumericCode => "981";

        /// <inheritdoc/>
        public string Name => "Georgian Lari";

        private GelCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new GelCurrency();
    }
}
