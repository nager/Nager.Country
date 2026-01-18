namespace Nager.Country.Currencies
{
    /// <summary>
    /// Vef Currency
    /// </summary>
    public sealed class VefCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Bs.S";

        /// <inheritdoc/>
        public string? Singular => "bolívar soberano";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "VEF";

        /// <inheritdoc/>
        public string NumericCode => "937";

        /// <inheritdoc/>
        public string Name => "Venezuelan bolívar fuerte";

        private VefCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new VefCurrency();
    }
}
