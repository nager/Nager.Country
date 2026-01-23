namespace Nager.Country.Currencies
{
    /// <summary>
    /// Cad Currency
    /// </summary>
    public sealed class CadCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollars";

        /// <inheritdoc/>
        public string IsoCode => "CAD";

        /// <inheritdoc/>
        public string NumericCode => "124";

        /// <inheritdoc/>
        public string Name => "Canadian dollar";

        private CadCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new CadCurrency();
    }
}
