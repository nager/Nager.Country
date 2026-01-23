namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bnd Currency
    /// </summary>
    public sealed class BndCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => "dollar";

        /// <inheritdoc/>
        public string? Plural => "dollars";

        /// <inheritdoc/>
        public string IsoCode => "BND";

        /// <inheritdoc/>
        public string NumericCode => "096";

        /// <inheritdoc/>
        public string Name => "Brunei dollar";

        private BndCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new BndCurrency();
    }
}
