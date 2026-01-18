namespace Nager.Country.Currencies
{
    /// <summary>
    /// Lsl Currency
    /// </summary>
    public sealed class LslCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "L";

        /// <inheritdoc/>
        public string? Singular => "Loti";

        /// <inheritdoc/>
        public string? Plural => "Maloti";

        /// <inheritdoc/>
        public string IsoCode => "LSL";

        /// <inheritdoc/>
        public string NumericCode => "426";

        /// <inheritdoc/>
        public string Name => "Lesotho loti";

        private LslCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new LslCurrency();
    }
}
