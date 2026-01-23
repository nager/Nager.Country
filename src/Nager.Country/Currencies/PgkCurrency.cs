namespace Nager.Country.Currencies
{
    /// <summary>
    /// Pgk Currency
    /// </summary>
    public sealed class PgkCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "K";

        /// <inheritdoc/>
        public string? Singular => "kina";

        /// <inheritdoc/>
        public string? Plural => "kina";

        /// <inheritdoc/>
        public string IsoCode => "PGK";

        /// <inheritdoc/>
        public string NumericCode => "598";

        /// <inheritdoc/>
        public string Name => "Papua New Guinean kina";

        private PgkCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new PgkCurrency();
    }
}
