namespace Nager.Country.Currencies
{
    /// <summary>
    /// Mvr Currency
    /// </summary>
    public sealed class MvrCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "ރ.";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "MVR";

        /// <inheritdoc/>
        public string NumericCode => "462";

        /// <inheritdoc/>
        public string Name => "Maldivian Rufiyaa";

        private MvrCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new MvrCurrency();
    }
}
