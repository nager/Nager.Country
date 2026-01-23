namespace Nager.Country.Currencies
{
    /// <summary>
    /// Nad Currency
    /// </summary>
    public sealed class NadCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "$";

        /// <inheritdoc/>
        public string? Singular => null;

        /// <inheritdoc/>
        public string? Plural => null;

        /// <inheritdoc/>
        public string IsoCode => "NAD";

        /// <inheritdoc/>
        public string NumericCode => "516";

        /// <inheritdoc/>
        public string Name => "Namibian dollar";

        private NadCurrency() { }

        /// <summary>
        /// Singleton instance of the currency.
        /// </summary>
        public static ICurrency Instance { get; } = new NadCurrency();
    }
}
