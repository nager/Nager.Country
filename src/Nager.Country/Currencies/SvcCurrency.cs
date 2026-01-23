namespace Nager.Country.Currencies
{
    /// <summary>
    /// Svc Currency
    /// </summary>
    public sealed class SvcCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₡";

        /// <inheritdoc/>
        public string? Singular => "colón";

        /// <inheritdoc/>
        public string? Plural => "colón";

        /// <inheritdoc/>
        public string IsoCode => "SVC";

        /// <inheritdoc/>
        public string NumericCode => "222";

        /// <inheritdoc/>
        public string Name => "Salvadoran colón";

        private SvcCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new SvcCurrency();
    }
}
