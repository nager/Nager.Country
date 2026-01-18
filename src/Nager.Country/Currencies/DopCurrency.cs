namespace Nager.Country.Currencies
{
    /// <summary>
    /// Dop Currency
    /// </summary>
    public sealed class DopCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "peso";

        /// <inheritdoc/>
        public string? Plural => "peso";

        /// <inheritdoc/>
        public string IsoCode => "DOP";

        /// <inheritdoc/>
        public string NumericCode => "214";

        /// <inheritdoc/>
        public string Name => "Dominican peso";

        private DopCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new DopCurrency();
    }
}
