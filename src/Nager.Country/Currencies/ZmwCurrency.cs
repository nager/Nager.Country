namespace Nager.Country.Currencies
{
    /// <summary>
    /// Zmw Currency
    /// </summary>
    public sealed class ZmwCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "K";

        /// <inheritdoc/>
        public string? Singular => "kwacha";

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "ZMW";

        /// <inheritdoc/>
        public string NumericCode => "967";

        /// <inheritdoc/>
        public string Name => "Zambian kwacha";

        private ZmwCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new ZmwCurrency();
    }
}
