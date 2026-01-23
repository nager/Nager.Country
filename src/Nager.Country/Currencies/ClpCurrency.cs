namespace Nager.Country.Currencies
{
    /// <summary>
    /// Clp Currency
    /// </summary>
    public sealed class ClpCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "peso";

        /// <inheritdoc/>
        public string? Plural => "peso";

        /// <inheritdoc/>
        public string IsoCode => "CLP";

        /// <inheritdoc/>
        public string NumericCode => "152";

        /// <inheritdoc/>
        public string Name => "Chilean peso";

        private ClpCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new ClpCurrency();
    }
}
