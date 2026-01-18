namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gnf Currency
    /// </summary>
    public sealed class GnfCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "FG";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "GNF";

        /// <inheritdoc/>
        public string NumericCode => "324";

        /// <inheritdoc/>
        public string Name => "Guinean franc";

        private GnfCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new GnfCurrency();
    }
}
