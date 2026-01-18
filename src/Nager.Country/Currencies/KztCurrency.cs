namespace Nager.Country.Currencies
{
    /// <summary>
    /// Kzt Currency
    /// </summary>
    public sealed class KztCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "₸";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "KZT";

        /// <inheritdoc/>
        public string NumericCode => "398";

        /// <inheritdoc/>
        public string Name => "Kazakhstani Tenge";

        private KztCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new KztCurrency();
    }
}
