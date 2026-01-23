namespace Nager.Country.Currencies
{
    /// <summary>
    /// Gip Currency
    /// </summary>
    public sealed class GipCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "�";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "GIP";

        /// <inheritdoc/>
        public string NumericCode => "292";

        /// <inheritdoc/>
        public string Name => "Gibraltar pound";

        private GipCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new GipCurrency();
    }
}
