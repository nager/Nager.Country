namespace Nager.Country.Currencies
{
    /// <summary>
    /// Czk Currency
    /// </summary>
    public sealed class CzkCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Kč";

        /// <inheritdoc/>
        public string? Singular => "koruna";

        /// <inheritdoc/>
        public string? Plural => "koruna";

        /// <inheritdoc/>
        public string IsoCode => "CZK";

        /// <inheritdoc/>
        public string NumericCode => "203";

        /// <inheritdoc/>
        public string Name => "Czech koruna";

        private CzkCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new CzkCurrency();
    }
}
