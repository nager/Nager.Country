namespace Nager.Country.Currencies
{
    /// <summary>
    /// Xcd Currency
    /// </summary>
    public sealed class XcdCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "EC$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "XCD";

        /// <inheritdoc/>
        public string NumericCode => "951";

        /// <inheritdoc/>
        public string Name => "East Caribbean Dollar";

        private XcdCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new XcdCurrency();
    }
}
